using GameSale.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Interface
{
    interface IDiscountService
    {
        void Discount(Games games);

        void DiscountFinish(Games games);
    }
}
