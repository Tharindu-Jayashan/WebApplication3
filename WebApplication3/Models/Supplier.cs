using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public String suplierName { get; set; }
        public DateTime  createdOn { get; set; }
        public Boolean isActive { get; set; }

        public ICollection<Product> products { get; set; }

    }
}