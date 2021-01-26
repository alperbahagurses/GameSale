using GameSale.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Entities
{
    internal class WinterSale : IDiscountService
    {
        double discountPrice ;
        public void Discount(Games games)
        {
            
            discountPrice = (games.GamePrice * (0.60));
            games.GamePrice = games.GamePrice - discountPrice;
            Console.WriteLine("Kış indirimi uygulandı !" + "\n" + "İndirimli " + games.GameName + " fiyat => " + games.GamePrice);
        }

        public void DiscountFinish(Games games)
        {

            games.GamePrice = games.GamePrice + discountPrice;

            Console.WriteLine("Kış indirimi bitti !" );
        }

    }
}
