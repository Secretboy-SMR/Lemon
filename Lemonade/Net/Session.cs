using Lemonade.Packet;
using Lemonade.Sniffer;
using Lemonade.Utils;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Lemonade.Net;

public class Session
{

    public async Task BackgroundCheck()
    {
        Update((uint)MonotonicTime.Now);

        if (_ikcp == null)
        {
            Log.Information("_ikcp is null!!!");
            return;
        }

        try
        {

            var recvArr = RecieveAll();

            foreach (byte[] recv in recvArr)
            {
                try
                {

                    Crypt(recv);

                    Packet.Packet packet = new Packet.Packet(recv);


                    var pktHandler = PacketHandlerFactory.NewInstance(packet.Type);



                    Log.Verbose("{name}: Sent packet with type {type}", user, packet.Type);

                    if (pktHandler != null)
                    {

                        Log.Verbose("Handling Packet {a}", packet.Type);
                        pktHandler.HandleAsync(packet, this).Wait();
                    }

                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                }
            }
        }
        catch (Exception e)
        {
            Log.Error(e.ToString());
        }

        var delay = (int)Check((uint)MonotonicTime.Now);


        if (delay >= 0)
        {
            await Task.Delay(delay);
            _ = BackgroundCheck();
        }
        else
        {

            // its 20 in nodelay so just going to default to this
            await Task.Delay(20);
            _ = BackgroundCheck();
        }


    }

    private readonly object lockObj = new object();

    private IKCP _ikcp;
    
    public string CS2PeerId;
    
    public World.World world;
    

    private MTKey _key;

    public MTKey Key
    {
        get { return _key; }
        set { _key = value; }
    }


    private string user;

    private IKCP.OutputDelegate output = (byte[] data, int length, object user) =>
    {
        //here would be where you would send data to the udp socket via information from the user arg
        //we dont send things here so no code here;

    };

    public Handler handler { get; private set; }

    private void Init(ulong conv, object user, Handler handler)
    {
        this.handler = handler;
        this.world = new();

        _ikcp = new IKCP(conv, user);


        _ikcp.NoDelay(1, 20, 1, 1);

        _ikcp.SetOutput(output);

        _ikcp.WndSize(256, 256);

        this.user = user.ToString();


        Log.Debug("Initialized kcp for {a}", this.user);
        Task.Run(BackgroundCheck);


    }



    public Session(ulong conv, object user, Handler handler)
    {
        Init(conv, user, handler);


    }

    public Session(ulong conv, string user, Handler handler)
    {

        Init(conv, user, handler);



    }




    public byte[][] RecieveAll()
    {
        List<byte[]> recvList = new();

        byte[] recv;

        do
        {
            recv = Recv();
            if (recv == null)
            {
                break;
            }
            recvList.Add(recv);

        } while (recv != null);

        //also copies it
        return recvList.ToArray();
    }

    public void Crypt(byte[] buffer)
    {
        if (_key == null)
            _key = KeyRecovery.FindKey(buffer);

        if (_key == null)
            throw new Exception("Unable to determine XOR key for session");

        _key.Crypt(buffer);
    }

    public void Update(uint tsCurrent)
    {
        if (_ikcp == null)
        {
            throw new Exception("Session not initialized yet...");
        }

        lock (lockObj)
        {
            _ikcp.Update(tsCurrent);
        }
    }

    public uint Check(uint tsCurrent)
    {
        if (_ikcp == null)
        {
            throw new Exception("Session not initialized yet...");
        }

        var delay = 20u;
        
        lock (lockObj)
        {
            delay = _ikcp.Check(tsCurrent) - tsCurrent;
        }

        return delay;
    }

    public byte[] Recv()
    {
        if (_ikcp == null)
        {
            throw new Exception("Session not initialized yet...");
        }

        int size = _ikcp.PeekSize();
        if (size < 0) return null;


        var buffer = new byte[size];

        lock (lockObj)
        {
            _ikcp.Recv(buffer, 0, buffer.Length);
        }


        return buffer.ToArray();
    }

    public void Input(byte[] buff)
    {
        if (_ikcp == null)
        {
            throw new Exception("Session not initialized yet...");
        }

        lock (lockObj)
        {
            _ikcp.Input(buff, 0, buff.Length);
        }
    }


    public void Dispose()
    {
        _ikcp = null;
    }
}
