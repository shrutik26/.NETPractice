using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;
using WebApplication2.Data.ViewModel;

namespace WebApplication2.Data.Services
{
    public class EmployeeService
    {
        private AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployeewithProduct(EmployeeVm employeeVm)
        {
            Employee _employee = new Employee()
            {
                Name = employeeVm.Name,
                Role = employeeVm.Role,
                Address = employeeVm.Address,
                ContactNo = employeeVm.ContactNo,
                DepartmentId = employeeVm.DepartmentId
            };
            _context.Employees.Add(_employee);
            _context.SaveChanges();

            foreach(var id in employeeVm.ProductId)
            {
                Product_Type product_Type = new Product_Type()
                {
                    EmployeeId = _employee.Id,
                    ProductId = id
                };
                _context.Product_Types.Add(product_Type);
                _context.SaveChanges();
            }
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public EmployeeVmWithProduct GetEmployeeWithProduct(int EmpId)
        {
            var _employeewithProduct = _context.Employees.Where(e => e.Id == EmpId).Select(emp => new EmployeeVmWithProduct()
            {
                Name = emp.Name,
                Role = emp.Role,
                Address = emp.Address,
                ContactNo = emp.ContactNo,
                DepartmentName = emp.department.DepartmentName,
                ProductName = emp.product_Types.Select(a => a.Product.ProductName).ToList()
            }).FirstOrDefault();
            return _employeewithProduct;
        }

        public Employee UpdateEmployee(int employeeId, EmployeeVm employeeVm)
        {
            var _employee = _context.Employees.FirstOrDefault(e => e.Id == employeeId);
            if(_employee != null  )
            {
                _employee.Name = employeeVm.Name;
                _employee.Role = employeeVm.Role;
                _employee.Address = employeeVm.Address;
                _employee.ContactNo = employeeVm.ContactNo;

                _context.SaveChanges();
            }
            return _employee;
        }

        public void DeleteEmployee(int employeeId)
        {
           var _employee =  _context.Employees.FirstOrDefault(e => e.Id == employeeId);
            if(_employee != null)
            {
                _context.Employees.Remove(_employee);
                _context.SaveChanges();
            }
        }
    }
}
