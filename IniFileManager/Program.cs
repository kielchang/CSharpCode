using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniFileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            InitSetting config = new InitSetting();

            FuckYou fuckyou = new FuckYou();
            fuckyou.print();

            config.displaySetting();

            Console.ReadLine();
        }
    }
}
