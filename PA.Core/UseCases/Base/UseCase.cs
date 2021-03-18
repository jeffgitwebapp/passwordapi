using System;
using MediatR;

namespace PA.Core.UseCases.Base
{
    public class UseCase
    {
        private readonly IMediator _mediator;

        public UseCase(IMediator mediator)
        {
            mediator = _mediator;
        }
    }
}
