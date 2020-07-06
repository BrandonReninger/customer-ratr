using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer_ratr.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace customer_ratr.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _cs;

        public CustomerController(CustomerService cs)
        {
            _cs = cs;
        }
    }
}