using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Models.Dto
{
    public class OrderLineDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Item { get; set; }
        public decimal Quantity { get; set; }
    }
}