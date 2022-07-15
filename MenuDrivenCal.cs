using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    class MenuDrivenCal
    {
        public void cal()
        {
            char choice;
            do
            {
                Console.WriteLine("Enter 2 numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter character:\n+ Add\n- Substract\n* Mulltiply\n / Divide");
                char c = Convert.ToChar(Console.ReadLine());


                switch (c)
                {
                    case '+':
                        Console.WriteLine("Add= " + (a + b));
                        break;
                    case '-':
                        Console.WriteLine("Substract= " + (a - b));
                        break;
                    case '*':
                        Console.WriteLine("Multiply= " + (a * b));
                        break;
                    case '/':
                        Console.WriteLine("Divide= " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.WriteLine("Do you want to continue(y/n)?");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
        }


    }
}
