using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime createdOn { get; set; }
        public Boolean isActive { get; set; }

        public ICollection<Order> orders { get; set; }

    }
}