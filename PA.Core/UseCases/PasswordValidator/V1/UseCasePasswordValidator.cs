using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PA.Core.UseCases.Base;

namespace PA.Core.UseCases.PasswordValidator.V1
{
    public class UseCasePasswordValidator : UseCase, IRequestHandler<CommandPasswordValidator, ResultPasswordValidator>
    {
        public UseCasePasswordValidator(IMediator mediator) : base(mediator)
        {
        }

        public Task<ResultPasswordValidator> Handle(CommandPasswordValidator request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                throw new InvalidOperationException("Password is required");
            }

            var passwordValidator = new Domain.Entities.PasswordValidator(request.Password);

            var validationResult = passwordValidator.PasswordIsValid();

            var result = new ResultPasswordValidator(validationResult);

            return Task.FromResult(result);
        }
    }
}
