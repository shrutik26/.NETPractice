using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Core.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;

        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public PaginetedCustomer GetCustomer(int page = 1, int postsPerPage = 10)
        {
            var results = _context.Customers.OrderBy(x => x.Id);
            return PaginetedCustomer.ToPaginatedPost(results, page, postsPerPage);
        }
    }
}
