using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApplication
{
    /// <summary>
    /// This class reads the config file to get the default server, database, username, and password (if the user chooses to use them).
    /// </summary>
    public static class Config
    {
        public static string Server;
        public static string Database;
        public static string Username;
        public static string Password;

        public static bool ReadConfig()
        {
            using (StreamReader sr = new StreamReader("..\\..\\config\\config.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    List<string> setting = line.Split('=').ToList();
                    
                    if(setting.Count == 0)
                    {
                        continue;
                    }
                    if(setting.Count != 2)
                    {
                        throw new Exception("Config file error! Check the config file.");
                    }

                    if (!Decode(setting[0], setting[1]))
                    {
                        throw new Exception("Config file error! Check the config file.");
                    }
                }

                return true;
            }
        }

        private static bool Decode(string setting, string arg)
        {
            switch(setting.ToLower())
            {
                case ("server"):
                    {
                        Server = arg;
                        break;
                    }
                case ("database"):
                    {
                        Database = arg;
                        break;
                    }
                case ("username"):
                    {
                        Username = arg;
                        break;
                    }
                case ("password"):
                    {
                        Password = arg;
                        break;
                    }
                default:
                    {
                        return false;
                    }
            }

            return true;
        }
    }
}
