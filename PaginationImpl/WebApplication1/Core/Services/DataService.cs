using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core.Repositories;
using WebApplication1.Data;

namespace WebApplication1.Core.Services
{
        public class DataService : IDataService
        {
            private readonly CustomerDbContext _context;

            public DataService(CustomerDbContext context)
            {
                _context = context;
            }

            public ICustomerRepository customer => new CustomerRepository(_context);
        }
}
