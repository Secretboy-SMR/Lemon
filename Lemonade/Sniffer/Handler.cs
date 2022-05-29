using Lemonade.Net;
using Lemonade.Packet;
using PacketDotNet;
using Serilog;
using SharpPcap;
using System;
using System.Threading;
using Lemonade.Utils;

namespace Lemonade.Sniffer;

public class Handler
{
    public Session? Client { get; private set; }
    private Session? _server;

    public MTKey Key;

    public Handler()
    {
        //i'm not quite sure why i made this static
        PacketHandlerFactory.InitializeFactory();
    }

    public void HandleRawCapture(RawCapture rawCapture)
    {
        IPv4Packet ipv4Packet = PacketDotNet.Packet.ParsePacket(LinkLayers.Ethernet, rawCapture.Data).Extract<IPv4Packet>();


        UdpPacket udpPacket = ipv4Packet.Extract<UdpPacket>();


        Destination destination = udpPacket.DestinationPort is 22101 or 22102 ? Destination.Server : Destination.Client;

        byte[] packetBytes = udpPacket.PayloadData;

        if (packetBytes.Length <= 20)
        {
            //handshake
            Handshake handshake = new Handshake();
            handshake.Decode(packetBytes);
            try
            {
                switch (handshake.Magic1)
                {
                    case 0xFF:

                        if (destination == Destination.Server)
                        {
                            Log.Debug("Client Requesting Conv...");
                        }
                        else
                        {
                            Log.Information("wow");
                        }
                        break;
                    case 0x145:

                        if (destination == Destination.Client)
                        {
                            Log.Debug("Server Handshake : {0}", handshake.Conv);
                            Client = new Session(handshake.Conv, "Client", this);

                            //this is shitty but we ignore this
                            Thread.Sleep(1);

                            _server = new Session(handshake.Conv, "Server", this);
                        }
                        else
                        {
                            Log.Information("wow");
                        }
                        //TODO: handle this
                        break;
                    case 0x194:
                        if (destination == Destination.Server)
                        {
                            Log.Debug("Client Removed: {0}", handshake.Conv);
                            Client?.Dispose();
                        }
                        else
                        {
                            Log.Debug("Server Removed: {0}", handshake.Conv);
                            _server?.Dispose();

                        }

                        break;
                    default:
                        //unhandled handshake
                        Log.Error("Unhandled Handshake");
                        break;
                }
            }
            catch (Exception e)
            {
                Log.Error("Handshake Error: {a}", e.ToString());
            }

        }
        else
        {

            if (Client is null || _server is null)
            {
                Log.Information("Ignoring {length} bytes...", packetBytes.Length);
                return;
            }
            if (destination == Destination.Server)
            {
                Client.Input(packetBytes);
            }
            else
            {
                _server.Input(packetBytes);
            }
        }




    }

    enum Destination
    {
        Server,
        Client
    }
}