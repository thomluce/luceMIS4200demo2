using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using luceMIS4200demo2.Models;

namespace luceMIS4200demo2.DAL
{
    public class MIS4200Context : DbContext 
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Order> orders  { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<LineItem> lineItems { get; set; }
     




    }
}