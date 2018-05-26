﻿using Microsoft.Extensions.DependencyInjection;
using Radix.Gateway.Domain;
using Radix.Gateway.Infra.Data.Repository;

namespace Radix.Gateway.Infra.Ioc
{
    public class InjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
