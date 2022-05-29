namespace Lemonade.Logging;

public class LogEntryHeal:LogEntry
{

    public float theoreticalHealValue;
    public float effectiveHealValue;
    public uint healerId;
    public string healerName;
    public string targetName;
    public uint targetId;
    
    
    public LogEntryHeal() : base(EntryType.Healing)
    {
        
    }
}