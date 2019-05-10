using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Models
{
    public class Order
    {
        public Customer Customer { get; set; }

        public decimal GetTotal()
        {
            return 100M;
        }
    }
}