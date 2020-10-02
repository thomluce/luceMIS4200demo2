using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace luceMIS4200demo2.Models
{
    public class LineItem
    {
        [Key]
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int productID { get; set; }
        public int ID { get; set; }
        public virtual Order orders  { get; set; }
        public virtual Product product { get; set; }
    }
}