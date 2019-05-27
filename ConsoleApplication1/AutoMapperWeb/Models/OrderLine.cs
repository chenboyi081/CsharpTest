using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Item Item { get; set; }
        public decimal Quantity { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}