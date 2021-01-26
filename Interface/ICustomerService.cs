using System;
using System.Collections.Generic;
using System.Text;

namespace GameSale.Interface
{
    interface ICustomerService
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string TcNo { get; set; }
        public int BirthDate { get; set; }
    }
}
