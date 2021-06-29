using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRABAJOFINAL.Models
{
    public class Invoice
    {

        public int ID { get; set; }

        public DateTime creation_date { get; set; }

        public string state { get; set; }

        public double total { get; set; }

        public string address { get; set; }

        public string folio { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
