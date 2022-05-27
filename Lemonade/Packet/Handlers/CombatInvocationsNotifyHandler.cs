using Lemonade.Net;
using Lemonade.Net.Protocol;
using Serilog;
using System.Threading.Tasks;

namespace Lemonade.Packet.Handlers;


public class CombatInvocationsNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        CombatInvocationsNotify cin = CombatInvocationsNotify.Parser.ParseFrom(incPacket.data);

        foreach (CombatInvokeEntry combatInvoke in cin.InvokeList)
        {
            //handle
            switch (combatInvoke.ArgumentType)
            {
                case CombatTypeArgument.CombatEvtBeingHit:

                    EvtBeingHitInfo evtBeingHitInfo = EvtBeingHitInfo.Parser.ParseFrom(combatInvoke.CombatData);
                    session.world.handleDamage(evtBeingHitInfo.AttackResult);
                    break;
                case CombatTypeArgument.EntityMove:

                    EntityMoveInfo entityMoveInfo = EntityMoveInfo.Parser.ParseFrom(combatInvoke.CombatData);
                    
                    break;
                
                default:
                    break;

            }

            

        }

    }

}

