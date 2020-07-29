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

    public class UsersController : ControllerBase
    {
        private readonly UsersService _us;

        public UsersController(UsersService us)
        {
            _us = us;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            try
            {
                return Ok(_us.GetById(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<User> Create([FromBody] User newUser)
        {
            try
            {
                return Ok(_us.Create(newUser));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            try
            {
                return Ok(_us.Delete(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<User> Edit(int id, [FromBody] User updateUser)
        {
            try
            {
                return Ok(_us.Edit(id, updateUser));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}