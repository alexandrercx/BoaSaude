using Application.Interface;
using Application.ViewModel.Request;
using Application.ViewModel.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AssociadoController : ControllerBase
    {
        private readonly IAssociadoAppService _associadoAppService;

        public AssociadoController(IAssociadoAppService associadoAppService)
        {
            _associadoAppService = associadoAppService;
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseAssociadoViewModel))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult Post([Required][FromBody] PostAssociadoViewModel associadoViewModel)
        {
            try
            {
                var responseAssociado = _associadoAppService.PostCadastroAssociado(associadoViewModel);
                return Ok(responseAssociado);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // GET api/values
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseAssociadoViewModel))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult GetByEmail([Required][FromQuery] string email)
        {
            try
            {
                var responseAssociado = _associadoAppService.GetCadastroAssociado(email);
                return Ok(responseAssociado);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // GET api/values
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ResponseAssociadoViewModel))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult GetById([Required][FromRoute] long id)
        {
            try
            {
                var responseAssociado = _associadoAppService.GetCadastroAssociado(id);
                return Ok(responseAssociado);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}