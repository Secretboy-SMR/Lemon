using System.IO;
using Lemonade.Logging;
using Serilog;

namespace Lemonade
{
    public static class OutputManager
    {

        public static string currentFile;
        static OutputManager()
        {
            if (!Directory.Exists("./Logs"))
            {
                Directory.CreateDirectory("./Logs");
                Log.Information("Created ./Logs Directory");
            }
            currentFile = System.DateTime.Now.ToString() + "-Log.log";

        }


        public static GameLogger CreateLog()
        {
            currentFile = System.DateTime.Now.ToString() + "-Log.log";
            return new GameLogger(currentFile);
        }
        
        
        
    }
}
