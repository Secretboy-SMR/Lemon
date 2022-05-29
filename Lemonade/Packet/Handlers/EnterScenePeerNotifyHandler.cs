using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class EnterScenePeerNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        EnterScenePeerNotify enterScenePeerNotify = EnterScenePeerNotify.Parser.ParseFrom(incPacket.Data);
        // this one tells client their peerId
    }

}