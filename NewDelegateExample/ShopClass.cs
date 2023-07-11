using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDelegateExample
{
    internal class ShopClass
    {
        public delegate void ShopDelegate();

        public int i;

        public ShopClass(int _i)
        {
            i = _i;
        }
        public void Choose()
        {
            i += 1;
            Console.WriteLine("choose()    ----");
        }

        public void Order()
        {
            i += 1;
            Console.WriteLine("Order()");
        }
        public void Pay()
        {
            i += 1;
            Console.WriteLine("Pay()");
        }

        public void Packaging()
        {
            i += 1;
            Console.WriteLine("Packaging()");
        }

        public void Shipping()
        {
            i += 1;
            Console.WriteLine("Shipping()");
        }

        public void OnBoarding()
        {
            i += 1;
            Console.WriteLine("On Boarding()");
        }

        public void Delivered()
        {
            i += 1;
            Console.WriteLine("Delivered()-------" + i);
        }
    }
}
