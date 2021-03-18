using Microsoft.Extensions.DependencyInjection;
using PA.Core.UseCases.PasswordValidator.V1;
using PA.Infra.DependencyInjection.IOCExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA.Infra.DependencyInjection
{
    public class DependencyInjection
    {
        private static ServiceProvider _service;

        public static void AddServices(IServiceCollection _service)
        {
            _service.AddMediatRForAssembly<UseCasePasswordValidator>();
        }

        public static Service GetServices<Service>()
        {
            return _service.GetService<Service>();
        }
    }
}
