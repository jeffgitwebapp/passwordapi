using PA.Core.UseCases.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Core.UseCases.PasswordValidator.V1
{
    public class CommandPasswordValidator : Command<ResultPasswordValidator>
    {
        public CommandPasswordValidator(string password)
        {
            Password = password;
        }

        public string Password { get; private set; }

        public override bool IsValid()
        {
            return !string.IsNullOrEmpty(Password);
        }
    }
}
