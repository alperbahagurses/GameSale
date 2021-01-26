using GameSale.Entities;
using GameSale.Interface;
using GameSale.Manager;
using System;

namespace GameSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "Alper Baha";
            customer1.SurName = "GÜRSES";
            customer1.TcNo="5645653";
            customer1.BirthDate = 1994;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.FirstName = "Burak";
            customer2.SurName = "TEKİN";
            customer2.TcNo = "564684553";
            customer2.BirthDate = 2000;

            Customer customer3 = new Customer();
            customer3.CustomerId = 2;
            customer3.FirstName = "Mehmet";
            customer3.SurName = "YILDIRIM";
            customer3.TcNo = "3588548654";
            customer3.BirthDate = 1990;

            Games games1 = new Games();
            games1.GameId = 1;
            games1.GameName = "GTA 5";
            games1.GamePrice = 100;

            Games games2 = new Games();
            games2.GameId = 2;
            games2.GameName = "RUST";
            games2.GamePrice = 89.90;

            Games games3 = new Games();
            games3.GameId = 3;
            games3.GameName = "Cyberpunk 2077";
            games3.GamePrice = 246.5;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.Update(customer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(games1);
            gameManager.Update(games1);
            gameManager.Delete(games1);

         
            
            WinterSale winterSale = new WinterSale();
            winterSale.Discount(games1);
            winterSale.Discount(games2);
            winterSale.Discount(games3);
           

            SellingManager sellingManager = new SellingManager();
            sellingManager.Sell(games1, customer1);
  
        }
    }
}
