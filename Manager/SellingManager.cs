using GameSale.Entities;
using GameSale.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Manager
{
    class SellingManager
    {
        public void Sell(Games games,ICustomerService customer)
        {
            Console.WriteLine(customer.FirstName+" => "+games.GameName+" "+games.GamePrice+" TL satın aldı.");
        }

        public void DiscountSell(IDiscountService discountService)
        {
            
        }
    }
}
