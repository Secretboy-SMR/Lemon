using Lemonade.Net.Protocol;

namespace Lemonade.World.Damage;

public class AttackInfo
{
    public long Timestamp;

    public AttackResult attackResult;

    public AttackInfo(AttackResult ar)
    {
        attackResult = ar;
        Timestamp = System.DateTime.Now.Ticks;
    }

}