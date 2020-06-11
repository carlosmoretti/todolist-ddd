using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    public static class Bootstrap
    {
        public static void Inject(ref IServiceCollection service)
        {
            service.AddScoped<ITodoRepository, TodoRepository>();
        }
    }
}
