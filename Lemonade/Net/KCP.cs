using System;
using System.Net;

namespace Lemonade.Net;

public class KCP
{
    private IKCP _ikcp;
    public string CS2PeerId;

    public KCP(ulong conv, KCPOBJ user)
    {
        _ikcp = new IKCP(conv, user);
        
        _ikcp.SetOutput((data, length, user) =>
        {
            // this shouldn't be called lol
            
        });
    }
    
    public KCP(ulong conv, string user)
    {
        _ikcp = new IKCP(conv, user);

        _ikcp.NoDelay(1, 20, 1, 1);
        _ikcp.SetOutput((data, length, user) =>
        {
            // this shouldn't be called lol
            
        });
    }


    public void Update(uint tsCurrent)
    {
        if (_ikcp == null)
        {
            throw new Exception("KCP not initialized yet...");
        }
        
        _ikcp.Update(tsCurrent);
    }

    public uint Check(uint tsCurrent)
    {
        if (_ikcp == null)
        {
            throw new Exception("KCP not initialized yet...");
        }

        
        return _ikcp.Check(tsCurrent);
    }

    public byte[] Recv()
    {
        if (_ikcp == null)
        {
            throw new Exception("KCP not initialized yet...");
        }

        int size = _ikcp.PeekSize();
        if (size < 0) return null;


        var buffer = new byte[size];


        int trueSize = _ikcp.Recv(buffer, 0, buffer.Length);

        if (trueSize != size) throw new Exception("Unexpected state");

        return buffer;
    }

    public int Input(byte[] buff)
    {
        if (_ikcp == null)
        {
            throw new Exception("KCP not initialized yet...");
        }

        return _ikcp.Input(buff, 0, buff.Length);
    }


    public void Dispose()
    {
        //lol?
    }
}

public struct KCPOBJ
{
    public IPAddress addr;
    public int port;
    public string name;
}