using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRABAJOFINAL.Models
{
    public partial class Detail_Invoice
    {
        public int ID { get; set; }

        public double quantity { get; set; }

        public double sub_total { get; set; }

        public double price { get; set; }

        public int ProductID { get; set; }

        public int InvoiceID { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
