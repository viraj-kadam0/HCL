using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL.OOPS
{
    class Shopping
    {
        public string name;
        public int quantity;
        public int pricePeritem;

        public void acceptDetails()
        {
            Console.WriteLine("Enter name, quantity, pricePeritem");
            name = Console.ReadLine();
            quantity= int.Parse(Console.ReadLine());    
            pricePeritem = int.Parse(Console.ReadLine());
        }

       // public void creatbill ()



    }
}
