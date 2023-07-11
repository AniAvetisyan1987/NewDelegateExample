using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDelegateExample
{
    internal class Class1
    {
        public delegate void Class1Delegate(ref int num);
        public static void Method1(ref int num)
        {
            num = num + 1;
            Console.WriteLine("Method1-------" + num); ;
        }
        public static void Method2(ref int num)
        {
            num = num + 2;
            Console.WriteLine("Method2-------" + num);
        }
        public static void Method3(ref int num)
        {
            num = num + 3;
            Console.WriteLine("Method2-------" + num);
        }
    }
}
