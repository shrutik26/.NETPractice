using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core.Repositories;

namespace WebApplication1.Core.Services
{
    public interface IDataService
    {
        ICustomerRepository customer { get; }
    }
}
