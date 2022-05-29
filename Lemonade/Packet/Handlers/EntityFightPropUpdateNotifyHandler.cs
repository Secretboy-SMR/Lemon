using Lemonade.Net;
using Lemonade.Net.Protocol;
using Lemonade.Utils;
using System.Threading.Tasks;


namespace Lemonade.Packet.Handlers;

public class EntityFightPropUpdateNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        EntityFightPropUpdateNotify efpun = EntityFightPropUpdateNotify.Parser.ParseFrom(incPacket.Data);

        foreach (var fp in efpun.FightPropMap)
        {
            session.World.Scene.ChangeEntityStats(efpun.EntityId, new FightPropPair()
            {
                PropType = fp.Key,
                PropValue = fp.Value
            });
        }
    }

}