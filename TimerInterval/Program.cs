using System;
using System.Timers;

namespace TimerInterval
{
    class Program
    {
        private static Timer timer;

        public static void Main()
        {
            ConsoleMode.DisbleQuickEditMode();

            Console.Error.WriteLine();
            Console.WriteLine();

            // Create a timer and set a two second interval.
            timer = new System.Timers.Timer();
            timer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            timer.AutoReset = true;

            // Start the timer
            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }
    }
}
