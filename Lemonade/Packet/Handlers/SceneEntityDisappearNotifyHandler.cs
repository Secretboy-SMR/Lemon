using System.Linq;
using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class SceneEntityDisappearNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        SceneEntityDisappearNotify disappearNotify = SceneEntityDisappearNotify.Parser.ParseFrom(incPacket.Data);

        session.World.RemoveEntities(disappearNotify.EntityList.ToArray(), disappearNotify.DisappearType);

    }

}