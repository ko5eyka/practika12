using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    internal class Settings
    {
        static void Main(string[] args)
        {
            Print();
        }
        public static readonly String Config;
        static Settings()
        {
            Config = @"C:\Configs\appsettings.json";
        }
        public static void Print()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {Config}");
        }
    }
}
