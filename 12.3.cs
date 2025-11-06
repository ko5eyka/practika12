using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3
{
    internal class ObjectCounter
    {
        static void Main(string[] args)
        {
            ObjectCounter obj = new ObjectCounter();
            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();

            Console.WriteLine($"Количество созданных экземпляров: {bbb()}");
        }
        public static int count = 0;
        public ObjectCounter()
        {
            count++;
        }
       
        public static int bbb()
        {
            return count;
        }
    }
}
