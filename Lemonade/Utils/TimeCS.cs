using System;
using System.Threading;

namespace Lemonade.Utils;

public class MonotonicTime
{
    private static bool flag = true;
    public static readonly MonotonicTime DefaultClock = new(now: Environment.TickCount & int.MaxValue);
    private readonly Thread thread;
    public long Resolution;

    public MonotonicTime(long resolution = 10, long now = 0)
    {
        Resolution = resolution;
        Time = now;
        thread = new Thread(Tick);
        thread.Start();
    }

    public long Time { get; private set; }

    public static long Now => DefaultClock.Time;

    private void Tick()
    {
        while (flag)
        {
            Time += Resolution;
            Thread.Sleep((int)Resolution);
        }
    }

    public static void Close()
    {
        flag = false;
    }
}