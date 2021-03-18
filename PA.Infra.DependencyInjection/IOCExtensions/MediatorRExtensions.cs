using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PA.Core.UseCases.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Infra.DependencyInjection.IOCExtensions
{
    internal static class MediatorRExtensions
    {
        public static void AddMediatRForAssembly<TUseCaseAssembly>(this IServiceCollection services) where TUseCaseAssembly: UseCase
        {
            services.AddMediatR(typeof(TUseCaseAssembly).Assembly);
        }
    }
}
