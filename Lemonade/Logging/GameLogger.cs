using System;
using System.IO;
using System.Text;

namespace Lemonade.Logging;

public class GameLogger
{
    private StringBuilder logBuilder = new StringBuilder();

    private string filename;
    public GameLogger(string fileName)
    {
        filename = fileName;

        logBuilder.AppendLine($"## ${getTimestamp()} - Lemonade for 2.6");
    }

    public void CloseLog()
    {
        File.WriteAllText(logBuilder.ToString(), filename);
    }

    public void AddEntry(LogEntry entry)
    {
        logBuilder.Append(getTimestamp());
        logBuilder.Append(",");
        logBuilder.AppendLine(entry.Encode());
    }

    private string getTimestamp()
    {

        //2022-05-17T18:37:39.0953340-07:00
        return DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK");

    }

    

    
    

}