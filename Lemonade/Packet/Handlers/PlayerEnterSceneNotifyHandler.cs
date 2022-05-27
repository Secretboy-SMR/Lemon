using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class PlayerEnterSceneNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        PlayerEnterSceneNotify pesn = PlayerEnterSceneNotify.Parser.ParseFrom(incPacket.data);

        session.world.Level = (int)pesn.WorldLevel;
        
        
        // session.world.addPlayer();
    }

}