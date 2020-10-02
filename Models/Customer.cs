using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace luceMIS4200demo2.Models
{
    public class Customer
    {
        public int customerID { get; set; }

        [Display (Name = "Customer First Name")]
        public string firstName { get; set; }

        [Display (Name = "Customer Last Name")]
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        [Display (Name = "Date Joined")]
        public DateTime customerSince { get; set; }
        public ICollection<Order> order { get; set; }
        public string fullName { get
            {
                return lastName + ", " + firstName;
            }
                }


    }
}