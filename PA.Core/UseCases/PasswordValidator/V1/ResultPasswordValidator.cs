using PA.Core.UseCases.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Core.UseCases.PasswordValidator.V1
{
    public class ResultPasswordValidator : IResult
    {
        public ResultPasswordValidator(bool isValid)
        {
            IsValid = isValid;
        }

        public bool IsValid { get; private set; }
    }
}
