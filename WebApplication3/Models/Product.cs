using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string productName { get; set; }
        public decimal unitPrice { get; set; }
        public DateTime createdOn { get; set; }
        public Boolean isActive { get; set; }

        public ICollection<Order> orders { get; set; }
    }

}