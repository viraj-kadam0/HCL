using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    class SpyNumber
    {
        public void spy()
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int add = 0;
            int multiply = 1;
            while (num1 > 0)
            {
                int r = num1 % 10;
                num1 /= 10;
                add= add + r;
                multiply = multiply * r;
            }
            if (add == multiply)
            {
                Console.WriteLine("Num is Spy number");
            }
            else
            {
                Console.WriteLine("Num is not Spy number");
            }
        }
     
    }
}