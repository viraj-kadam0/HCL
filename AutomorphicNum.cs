using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    internal class AutomorphicNum
    {
       public void auto ()
        {
            bool isAuto = true;
            int num= int.Parse(Console.ReadLine());
            int sq = num * num;
            Console.WriteLine("Square="+ sq);

            while (num > 0)
            {

                if (num % 10 != sq % 10)

                {
                    isAuto = false;
                    break;
                }
                num /= 10;
                sq /= 10;
            }

            if (isAuto)
            {
                Console.WriteLine("Automorphic");

            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }

    }
}
