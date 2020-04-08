using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepConsoleReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input \"exit\" to exit the program at any time... ");
            string cmd = "";
            while ((cmd = Console.ReadLine()) != "exit")
            {
                Console.WriteLine($"cmd: {cmd}");

                if (cmd.Equals("1a2b"))
                {
                    Console.WriteLine("Start Playing... ");
                    Console.WriteLine("Input \"exit\" to exit game... ");

                    string answer = "";
                    while ((answer = Console.ReadLine()) != "exit")
                    {
                        Console.WriteLine($"1a2b: {answer}");
                    }
                }
            }
        }
    }
}
