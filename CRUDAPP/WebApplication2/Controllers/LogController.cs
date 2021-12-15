using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        public LogService _logService;
        public LogController(LogService logService)
        {
            _logService = logService;
        }

        [HttpGet("get-log-from-db")]
        public IActionResult GetLogFromDb()
        {
            var logData = _logService.GetAllLogsFromDb();
            return Ok(logData);
        }
    }
}
