using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace luceMIS4200demo2.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
        public ICollection<LineItem> lineItem { get; set; }
        public string orderDescription
        {
            get
            {
                return "Order by " + customer.fullName + ". Description: " + description;
            }
        }

    }
}