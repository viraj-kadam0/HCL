using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
     class Oddnums
    {
        public void oddnum1to10 ()
        {
            int count =0;
            for (int i = 0; i <= 10; i++) 
            {
                if(i%2!=0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);   
        }
    }
}
