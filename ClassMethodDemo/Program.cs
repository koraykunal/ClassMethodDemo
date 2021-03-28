using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = "11515741128";
            customer1.Name = "Koray";
            customer1.Surname = "Kunal";

            Customer customer2 = new Customer();
            customer2.ID = "27583776200";
            customer2.Name = "Elifnaz";
            customer2.Surname = "Kunal";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CartManager cart = new CartManager();
            cart.Add(customer1);

            cart.Listing(customers);

            cart.Delete(customer2);



        }
    }
}
