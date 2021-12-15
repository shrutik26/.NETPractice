using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Services;
using WebApplication2.Data.ViewModel;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentService _departmentService;

        public DepartmentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment([FromBody] DeptVm deptVm)
        {
            _departmentService.AddDepartment(deptVm);
            return Ok();
        }

        [HttpGet("GetDepartment")]
        public IActionResult GetAllDepartment()
        {
            var dept = _departmentService.GetDepartment();
            return Ok(dept);
        }


        [HttpGet("GetDepartment/{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var dept = _departmentService.GetDepartmentById(id);
            return Ok(dept);
        }
    }
}
