using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;
using WebApplication2.Data.ViewModel;

namespace WebApplication2.Data.Services
{
    public class DepartmentService
    {
        private AppDbContext _context;
        public DepartmentService(AppDbContext context)
        {
            _context = context;
        }

        public void AddDepartment(DeptVm deptVm)
        {
            Department _department = new Department()
            {
                DepartmentName = deptVm.DepartmentName
            };
            _context.Departments.Add(_department);
            _context.SaveChanges();
        }
        public List<Department> GetDepartment()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var _dept = _context.Departments.FirstOrDefault(e => e.DepartmentId == id );
            return _dept;
        }


    }
}
