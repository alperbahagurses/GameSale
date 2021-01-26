using GameSale.Entities;
using GameSale.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Manager
{
    class GameManager
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.GameName + " oyun eklendi !");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.GameName + " oyun silindi !");
        }

        public void Update(Games games)
        {
            Console.WriteLine(games.GameName + " oyun güncellendi !");
        }

        
    }
}
