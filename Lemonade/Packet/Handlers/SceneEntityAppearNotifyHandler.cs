using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Linq;
using System.Threading.Tasks;



namespace Lemonade.Packet.Handlers;

public class SceneEntityAppearNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public new async Task HandleAsync(Packet incPacket, Session session)
    {
        // session.world
        SceneEntityAppearNotify appearNotify = SceneEntityAppearNotify.Parser.ParseFrom(incPacket.data);
        foreach (SceneEntityInfo entityInfo in appearNotify.EntityList)
        {
            session.world.addEntity(entityInfo);
        }
    }
}
