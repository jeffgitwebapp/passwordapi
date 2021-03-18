using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PA.Api.Models.PasswordValidator.V1;
using PA.Core.UseCases.PasswordValidator.V1;

namespace PA.Api.Controllers
{
    [Route("api/pa/validations")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PasswordController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("v1/password")]
        public async Task<IActionResult> PostAsync([FromBody] RequestPasswordValidatorModel requestPasswordValidatorModel)
        {
            try
            {
                var command = new CommandPasswordValidator(requestPasswordValidatorModel.Password);

                var result = await _mediator.Send(command).ConfigureAwait(false);

                return Ok(result.IsValid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}