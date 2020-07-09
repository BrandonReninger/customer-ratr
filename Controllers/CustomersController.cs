using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer_ratr.Models;
using customer_ratr.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace customer_ratr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CustomersController : ControllerBase
    {
        private readonly CustomersService _cs;

        public CustomersController(CustomersService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAll()
        {
            try
            {
                return Ok(_cs.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}