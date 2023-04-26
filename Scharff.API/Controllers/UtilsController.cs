using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scharff.API.Utils.Models;
using Scharff.Application.Queries.Utils.VerifyIdentifyClient;
using Scharff.Domain.Entities;
using Swashbuckle.AspNetCore.Annotations;

namespace Scharff.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UtilsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(template: "{numberDocumentIdentity}")]
        [SwaggerResponse(200, "Retorna datos del cliente en base a su numero de documento.", typeof(CustomResponse<ClientModel>))]
        [SwaggerResponse(204, "No se encontro el cliente")]
        [SwaggerResponse(400, "Ocurrio un error de validacion")]
        public async Task<IActionResult> VerifyIdentityClient(string numberDocumentIdentity)
        {
            VerifyIdentityClientQuery request = new() { NumberDocumentIdentity = numberDocumentIdentity };

            var result = await _mediator.Send(request);
            return Ok(new CustomResponse<ClientModel>($"Se encontro el cliente con número de documento: {numberDocumentIdentity}.", result));
        }

    }
}
