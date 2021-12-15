using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class EmployeeController : ControllerBase
    {
        public EmployeeService _employeeService;
        public readonly ILogger<EmployeeController> _logger;

        public EmployeeController(EmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet("GetEmployee")]
        public IActionResult GetAllEmployees()
        {
            _logger.LogInformation("This is a log in GetAllEmployees()");
            var employees = _employeeService.GetEmployees();
            return Ok(employees);
        }


        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployeesWithProduct(int id)
        {
            var employees = _employeeService.GetEmployeeWithProduct(id);
            return Ok(employees);
        }


        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody]EmployeeVm employeeVm)
        {
            _employeeService.AddEmployeewithProduct(employeeVm);
            return Ok();
        }

        [HttpPut("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee( int id, [FromBody] EmployeeVm employeeVm)
        {
            var updateEmployee = _employeeService.UpdateEmployee(id, employeeVm);
            return Ok(updateEmployee);
        }


        [HttpDelete("DeleteEmployee/{id}")]
        public IActionResult DeletEmployee(int id)
        {
             _employeeService.DeleteEmployee(id);
            return Ok();
        }

    }
}
