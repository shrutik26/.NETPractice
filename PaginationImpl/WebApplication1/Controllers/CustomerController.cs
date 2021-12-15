using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core;
using WebApplication1.Core.Services;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly IDataService _db;
        public CustomerService _customerService;
        public CustomerDbContext _context;

        public CustomerController(CustomerService customerService,CustomerDbContext context,IDataService db) 
        {
            _customerService = customerService;
            _context = context;
            _db = db;
        }

        [HttpGet("GetCustomersByPagining")]
        public PaginetedCustomer Get([FromQuery] QueryParams qp)
        {
            return _db.customer.GetCustomer(qp.Page, qp.PostsPerPage);

        }

        [HttpGet("GetCustomers")]
        public IActionResult GetAllEmployees()
        {
            var customers = _customerService.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("GetCustomers/{id}")]
        public IActionResult GetEmployeesById(int id)
        {
            var customers = _customerService.GetCustomerById(id);
            return Ok(customers);
        }
    }
}
