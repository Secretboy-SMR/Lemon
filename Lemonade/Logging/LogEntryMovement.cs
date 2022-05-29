namespace Lemonade.Logging;

public class LogEntryMovement:LogEntry
{
    public Vector Pos;
    public Vector Rot;
    
    
    
    public LogEntryMovement() : base(LogEntry.EntryType.MoveData)
    {
        
    }

    public struct Vector
    {
        public float X;
        public float Y;
        public float Z;
    }
}