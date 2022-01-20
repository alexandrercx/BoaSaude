using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociadoController : ControllerBase
    {

        // POST api/values
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult Post([Required][FromBody] string value)
        {
            try
            {
                int Id = 0;
                return Ok(Id);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}