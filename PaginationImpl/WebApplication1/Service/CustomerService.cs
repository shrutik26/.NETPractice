using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class CustomerService
    {

        private CustomerDbContext _context;
        public CustomerService(CustomerDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var _customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            return _customer;
        }
    }
}
