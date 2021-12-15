using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.ViewModel
{
    public class EmployeeVm
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public int DepartmentId { get; set; }

        public List<int> ProductId { get; set; }
    }

    public class EmployeeVmWithProduct
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public string DepartmentName { get; set; }

        public List<string> ProductName { get; set; }
    }
}
