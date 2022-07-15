using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL.OOPS
{
    internal class Car
    {
        public int modelNumber;
        public string name;
        public int price;

        public void setCarDetails()
        {
            Console.WriteLine("Enter Model NUmber");
            modelNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            name=Console.ReadLine();

            Console.WriteLine("Enter Price");
            price=int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine(modelNumber + "\n"+ name +"\n" +price);
        }

    }

}
