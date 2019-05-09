using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperWeb.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}