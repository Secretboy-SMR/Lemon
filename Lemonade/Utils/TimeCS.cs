using System;
using System.Threading;

namespace Lemonade.Utils;

public class TimeCs
{
    private static bool _flag = true;
    public bool _paused = false;
    
    public static readonly TimeCs DefaultClock = new(now: Environment.TickCount & int.MaxValue);
    private readonly Thread _thread;
    public long Resolution;

    public void Pause(bool pflag)
    {
        _paused = pflag;

    }
    public TimeCs(long resolution = 10, long now = 0)
    {
        Resolution = resolution;
        Time = now;
        _thread = new Thread(Tick);
        _thread.Start();
    }

    public long Time { get; private set; }

    public static long Now => DefaultClock.Time;

    private void Tick()
    {
        while (_flag)
        {
            if(!_paused) Time += Resolution;
            Thread.Sleep((int)Resolution);
        }
    }

    public static void Close()
    {
        _flag = false;
    }
}