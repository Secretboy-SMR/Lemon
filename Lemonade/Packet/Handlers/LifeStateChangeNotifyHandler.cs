using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;
using Serilog;


namespace Lemonade.Packet.Handlers;

public class LifeStateChangeNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        LifeStateChangeNotify lifeStateChangeNotify = LifeStateChangeNotify.Parser.ParseFrom(incPacket.Data);
        
        Log.Information("Entity {asdf} changed lifestate to: {asdfg} because of {af}",lifeStateChangeNotify.EntityId, lifeStateChangeNotify.DieType, lifeStateChangeNotify.AttackTag );
    }

}