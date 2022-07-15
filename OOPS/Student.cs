using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL.OOPS
{
     class Student
    {
        public int id;
        public string name;
        public float m1;
        public float m2;
        public float m3;
        public float percentage;

        public void setDetails()
        {
            Console.WriteLine("Enter Student Id");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter marks for m1, m2 and m3 subjects");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
        }

        public void calculate()
        {
            float total = m1 + m2 + m3;
            percentage = (total / 300) * 100;
        }

        public void displayPercentage()
        {

            Console.WriteLine("Percentage=" + percentage + "%");
        }

    }
}
