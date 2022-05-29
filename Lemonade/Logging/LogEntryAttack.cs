namespace Lemonade.Logging;

public class LogEntryAttack:LogEntry
{
    public string DefenderName;
    public int DefenderEntityId;
    public int FrameNum;
    public float Damage;
    public bool isCrit;

    public int ownerId;
    public string ownerName;
    
    
    
    public LogEntryAttack() : base(EntryType.Attack)
    {

    }
}