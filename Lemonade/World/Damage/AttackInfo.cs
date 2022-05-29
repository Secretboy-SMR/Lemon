using Lemonade.Net.Protocol;

namespace Lemonade.World.Damage;

public class AttackInfo
{
    public long Timestamp;

    public AttackResult AttackResult;

    public AttackInfo(AttackResult ar)
    {
        AttackResult = ar;
        Timestamp = System.DateTime.Now.Ticks;
    }

}