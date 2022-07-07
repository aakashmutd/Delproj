using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_application
{
    public class Customer
    {
        public int CustomerID;


        public string CreateCustomer()
        {
            Console.WriteLine("Customer Created");
            return "1";
        }

        public void SelectCustomer()
        {
            Console.WriteLine("Customer selected");
        }
    }
}
