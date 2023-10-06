using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int orderStatus { get; set; }
        public int orderType { get; set; }
        public DateTime orderedOn { get; set; }
        public DateTime shippedOn { get; set; }
        public Boolean isAcive { get; set; }
    }
}