using GameSale.Entities;
using GameSale.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Manager
{
    class CustomerManager
    {
        public void Add(ICustomerService customer)
        {
            Console.WriteLine(customer.FirstName + " sisteme eklendi !");
        }

        public void Delete(ICustomerService customer)
        {
            Console.WriteLine(customer.FirstName + " sistemden silindi !");
        }

        public void Update(ICustomerService customer)
        {
            Console.WriteLine(customer.FirstName + " sistemde güncellendi !");
        }

       
    }
}
