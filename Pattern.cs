using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
     class Pattern
    {
         //Print Pattern
         // ****
         // ***
         // **
         // *
        

        public void pat1 ()
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Print pattern 
        //1
        //12
        //123
        //1234
        public void pat2()
              {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        //Print pattern 
        //1
        //22
        //333
        //4444
        public void pat3()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
