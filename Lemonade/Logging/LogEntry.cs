using Lemonade.Utils;
using Serilog;

namespace Lemonade.Logging;

public abstract class LogEntry
{
    public string Timestamp;
    public string AttackerName;
    public int AttackerEntityId;

    public static bool LogToConsole = true;
    



    private EntryType _entryType;

    public LogEntry(EntryType type)
    {

    }

    public string Encode()
    {
        var a = ToString();
        if(LogToConsole) Log.Information(a);
        return a;
    }

    public override string ToString()
    {

        return CSVSerializer.ToCsv(",", 
            new[]{ this});
    }

    public enum EntryType
    {
        
        //the damage
        Attack,
        
        
        Healing,
        
        //stat changes
        //mostly in ability invokes (oh so fun)
        StatChange,
        EntityInfo,
        MoveData,
        Debug,

    }
}