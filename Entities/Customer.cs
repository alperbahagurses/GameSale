using GameSale.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Entities
{
    class Customer : ICustomerService
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public int BirthDate { get; set; }
    }
}
