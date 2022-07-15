using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    class Armstrong
    {
        public void armst()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum= sum+(r*r*r);
                num= num/10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}
