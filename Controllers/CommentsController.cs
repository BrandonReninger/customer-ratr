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

    public class CommentsController : ControllerBase
    {
        private readonly CommentsService _cos;

        public CommentsController(CommentsService cos)
        {
            _cos = cos;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Comment>> GetAll()
        {
            try
            {
                return Ok(_cos.Getall());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}