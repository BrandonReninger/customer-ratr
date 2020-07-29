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
        private readonly CommentsService _cos;

        public CustomersController(CustomersService cs, CommentsService cos)
        {
            _cs = cs;
            _cos = cos;
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

        [HttpGet("{id}")]
        public ActionResult<Customer> GetById(int id)
        {
            try
            {
                return Ok(_cs.GetById(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // [HttpGet("{id}/comments")]
        // public ActionResult<IEnumerable<Comment>> GetCommentsByCustomerId(int id)
        // {
        //     try
        //     {
        //         return Ok(_cos.GetCommentsByCustomerId(id));
        //     }
        //     catch (System.Exception err)
        //     {
        //         return BadRequest(err.Message);
        //     }
        // }

        [HttpPost]
        public ActionResult<Customer> Create([FromBody] Customer newCustomer)
        {
            try
            {
                return Ok(_cs.Create(newCustomer));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(int id)
        {
            try
            {
                return Ok(_cs.Delete(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Customer> Edit(int id, [FromBody] Customer updateCustomer)
        {
            try
            {
                return Ok(_cs.Edit(id, updateCustomer));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}