using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerDBContext customerDB = new CustomerDBContext();
        // GET: api/Customer
        public IEnumerable<Customer> Get()
        {
            return customerDB.customers;
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public string Post([FromBody] Customer customer)
        {
            customerDB.customers.Add(customer);
            customerDB.SaveChanges();
            return "Data Saved Successfully";
        }

        // PUT: api/Customer/5
        public string Put(int id, [FromBody]Customer customer1)
        {
            var result = customerDB.customers.FirstOrDefault(k => k.Id == id);
            result.userName= customer1.userName;
            result.firstName= customer1.firstName;
            result.lastName= customer1.lastName;
            result.email= customer1.email;
            result.createdOn = customer1.createdOn;
            result.isActive= customer1.isActive;
            customerDB.SaveChanges();
            return "Update Successsfully";
            
           
        }

        // DELETE: api/Customer/5
        public string Delete(int id)


        {
            var res = customerDB.customers.Find(id);
            customerDB.customers.Remove(res);
            customerDB.SaveChanges() ;
            return "Deleted";
        }
    }
}
