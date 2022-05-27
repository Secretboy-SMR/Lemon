using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class EnterScenePeerNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet IncPacket, Session session)
    {
        EnterScenePeerNotify enterScenePeerNotify = EnterScenePeerNotify.Parser.ParseFrom(IncPacket.data);
        // this one tells client their peerId
    }

}