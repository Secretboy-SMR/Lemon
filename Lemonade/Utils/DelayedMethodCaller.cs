using System;
using System.Timers;

namespace Lemonade.Utils;

public class DelayedMethodCaller
{
    int _delay;
    Timer _timer = new Timer();

    public DelayedMethodCaller(int delay)
    {
        _delay = delay;
    }

    
    //this will stop and start the timer
    //will not save how much time is left 
    //but its not necessary
    public void setPaused(bool flag)
    {
        if (flag)
        {
            _timer.Stop();
        }
        else
        {
            _timer.Start();
        }
    }
    

    public void CallMethod(Action action)
    {
        if (!_timer.Enabled)
        {
            _timer = new Timer(_delay)
            {
                AutoReset = false
            };
            _timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                action();
            };
            _timer.Start();
        }
        else
        {
            _timer.Stop();
            _timer.Start();
        }
    }
}