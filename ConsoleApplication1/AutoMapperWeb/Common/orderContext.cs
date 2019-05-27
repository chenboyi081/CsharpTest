using AutoMapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Common
{
    public class orderContext : DbContext
    {
        public orderContext(): base()
        {

        }

        public DbSet<OrderLine> OrderLines { get; set; }
        //public DbSet<Standard> Standards { get; set; }
    }
}