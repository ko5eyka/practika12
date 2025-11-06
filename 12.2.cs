using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2
{
    internal class ProgramConfig
    {
        static void Main(string[] args)
        {
            Print();
        }
        public const String Version = "1.0.1";
        public const String Name = "Ваша совесть";
        public static void Print()
        {
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Имя разработчика: {Name}");
        }
    }
}
