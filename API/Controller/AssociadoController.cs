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
        public IActionResult Post([Required][FromQuery] string key, [Required][FromBody] PostAssociadoViewModel associadoViewModel)
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

    }
}