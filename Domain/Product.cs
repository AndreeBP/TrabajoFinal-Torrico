using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Product
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Double price { get; set; }
        public virtual ICollection<Detail_Invoice> Invoice_details { get; set; }

    }
}
