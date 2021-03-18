using PA.Core.UseCases.Base;
using PA.Core.UseCases.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Api.Models.PasswordValidator.V1
{
    public class RequestPasswordValidatorModel
    {
        public string Password { get; set; }
    }
}
