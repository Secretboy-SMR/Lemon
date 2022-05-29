using Lemonade.Net;
using Lemonade.Net.Protocol;
using Serilog;
using System.Threading.Tasks;

namespace Lemonade.Packet.Handlers;


public class CombatInvocationsNotifyHandler : PacketHandlerFactory.IPacketHandler
{
    public async Task HandleAsync(Packet incPacket, Session session)
    {
        CombatInvocationsNotify cin = CombatInvocationsNotify.Parser.ParseFrom(incPacket.Data);

        foreach (CombatInvokeEntry combatInvoke in cin.InvokeList)
        {
            //handle
            switch (combatInvoke.ArgumentType)
            {
                case CombatTypeArgument.CombatEvtBeingHit:

                    EvtBeingHitInfo evtBeingHitInfo = EvtBeingHitInfo.Parser.ParseFrom(combatInvoke.CombatData);
                    session.World.HandleDamage(evtBeingHitInfo.AttackResult);
                    break;
                case CombatTypeArgument.EntityMove:

                    EntityMoveInfo entityMoveInfo = EntityMoveInfo.Parser.ParseFrom(combatInvoke.CombatData);
                    
                    session.World.MoveEntity(entityMoveInfo.EntityId, entityMoveInfo.MotionInfo);
                    
                    break;
                // case CombatTypeArgument.CombatNone:
                // case CombatTypeArgument.CombatRushMove:
                // case CombatTypeArgument.CombatSyncTransform:
                // case CombatTypeArgument.SyncEntityPosition:
                // case CombatTypeArgument.CombatAnimatorParameterChanged:
                // case CombatTypeArgument.CombatAnimatorStateChanged:
                case CombatTypeArgument.CombatFaceToDir:
                    break;
                default:
                    Log.Information("CombatInvokeType {Type} is not processed...", combatInvoke.ArgumentType);
                    break;

            }

            

        }

    }

}

