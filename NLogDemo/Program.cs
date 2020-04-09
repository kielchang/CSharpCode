using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntervalLogger intervalLogger = new IntervalLogger();
            intervalLogger.start();

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
            intervalLogger.stop();
        }
    }
}
