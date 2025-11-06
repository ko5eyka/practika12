using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            if (double.TryParse(Console.ReadLine(), out double a)) { }
            else { Console.WriteLine("Ошибка, введите число!"); return; }

            Console.Write("Введите первое число: ");
            if (double.TryParse(Console.ReadLine(), out double b)) { }
            else { Console.WriteLine("Ошибка, введите число!"); return; }

            double add = Addition(a, b);
            double diff = Differense(a, b);
            double mult = Multiplication(a, b);
            double div = Division(a, b);
            Console.WriteLine($"Числа: {a}, {b}\nСложение: {add}\nРазность: {diff}\nПроизведение: {mult}");
            if (b == 0)
            {
                Console.WriteLine("Деление: Ошибка! На 0 делить нельзя!");
            }
            else
            {
                Console.WriteLine($"Деление: {div}");
            }
        }
        public static double Addition(double a, double b) 
        {
            return a + b;
        }
        public static double Differense(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
