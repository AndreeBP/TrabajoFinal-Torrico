using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRABAJOFINAL.Models
{
    public partial class Product
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }
    }
}
