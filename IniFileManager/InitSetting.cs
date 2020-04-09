using IniParser;
using IniParser.Model;
using System;
using System.IO;

namespace IniFileManager
{
    class InitSetting
    {
        private const string path = "Configuration.ini";
        public IniData data { get; set; }
        public string name { get; set; }

        public InitSetting() {
            var parser = new FileIniDataParser();
            if (File.Exists(path))
            {
                data = parser.ReadFile("Configuration.ini");
            }
            else {
                Init();
            }

            Console.WriteLine($"Hello {data["info"]["name"]}");
        }

        private void Init() {
            Console.WriteLine("Tell me a name:");
            string name = Console.ReadLine();
            data = new IniData();
            data["info"]["name"] = name;

            var parser = new FileIniDataParser();
            parser.WriteFile(path, data);
        }

        public void displaySetting() {
            Console.WriteLine($"Setting: \r\n {data}");
        }
    }
}
