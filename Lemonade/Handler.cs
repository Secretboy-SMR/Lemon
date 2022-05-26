using System.Windows.Interop;
using Lemonade.Packet;
using PacketDotNet;
using SharpPcap;

namespace Lemonade;

public class Handler
{
    public Handler()
    {
        //i'm not quite sure why i made this static
        PacketHandlerFactory.InitializeFactory();
    }

    public void HandlePacket(RawCapture rawCapture)
    {
        IPv4Packet ipv4Packet = PacketDotNet.Packet.ParsePacket(LinkLayers.Ethernet, rawCapture.Data).Extract<IPv4Packet>();
        
        
        UdpPacket udpPacket = ipv4Packet.Extract<UdpPacket>();
        MsgSender sender = udpPacket.DestinationPort == (ushort) 22101 || udpPacket.DestinationPort == (ushort) 22102 ? MsgSender.Client : MsgSender.Server;

        byte[] packetBytes = udpPacket.PayloadData;
        
        
    }

    enum MsgSender
    {
        Server,
        Client
    }
}