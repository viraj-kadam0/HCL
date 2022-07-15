using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
     class Table
    {
        public void printTable ()
        {
            Console.WriteLine("Enter Number to find a Table");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i*number);
            }
               Console.ReadLine();
        }
    }
}
