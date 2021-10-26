using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiseExtentions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            return services;
        }

    }
}
