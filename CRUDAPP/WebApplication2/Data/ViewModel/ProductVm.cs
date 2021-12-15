using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.ViewModel
{
    public class ProductVm
    {
        public string  ProductName { get; set; }
    }

    public class ProductWithEmployeeVm
    {
        public string ProductName { get; set; }

        public List<String> EmployeeName { get; set; }
    }
}
