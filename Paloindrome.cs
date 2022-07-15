using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
     class Paloindrome
    {
        public void palindro()
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0; 
            int num1 = num;
            while(num1> 0)
            {
                int r = num1 % 10;
                reverse = reverse  * 10 + r;    
                num1 /= 10;  
            }
            if (reverse == num)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindeome");
            }
        }
        

    }
}
