using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Core.Repositories
{
    public interface ICustomerRepository
    {
        PaginetedCustomer GetCustomer(int page = 1, int postsPerPage = 10);
    }
}
