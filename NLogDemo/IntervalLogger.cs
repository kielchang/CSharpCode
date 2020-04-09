using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NLogDemo
{
    class IntervalLogger
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static Timer timer;

        public IntervalLogger() {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Logger.Info("Hello world");
            Console.WriteLine($"Add Log at {e.SignalTime}");
        }

        public void start() {
            timer.Enabled = true;
        }

        public void stop() {
            timer.Enabled = false;
        }
    }
}
