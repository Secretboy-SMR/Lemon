using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class PlayerEnterSceneNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        PlayerEnterSceneNotify pesn = PlayerEnterSceneNotify.Parser.ParseFrom(incPacket.Data);

        session.World.Level = (int)pesn.WorldLevel;
        
        session.World.ChangeScene(pesn.SceneId);
        
        // session.world.addPlayer();
    }

}