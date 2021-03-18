using MediatR;
using PA.Core.UseCases.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Core.UseCases.Base
{
    public abstract class Command<TResult> : IRequest<TResult>, ICommand
    {
        public abstract bool IsValid();
    }
}
