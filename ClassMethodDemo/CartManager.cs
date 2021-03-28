using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CartManager
    {
        public void Add(Customer cust)
        {
            Console.WriteLine(cust.Name + " added to the system.");
        }
        public void Delete(Customer cust)
        {
            Console.WriteLine(cust.Name + " deleted from the system.");
        }
        public void Listing(Customer[] customers)
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c.Name);
            }
        }

    }
}
