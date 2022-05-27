using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class SceneEntityDisappearNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        SceneEntityDisappearNotify disappearNotify = SceneEntityDisappearNotify.Parser.ParseFrom(incPacket.data);

        foreach (var entityId in disappearNotify.EntityList)
        {
            session.world.RemoveEntity(entityId);
        }
    }

}