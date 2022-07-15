using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    class Digits
    {
        public void count()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            /** while (num > 0)
            {
                count++;
                num = num / 10;
            } **/
            for(int n = num; n > 0; n=n/10)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
