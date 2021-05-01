using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParameterStoreReload
{
    public static class SystemManagerConfiguration
    {

        public static void ConfigureSystemanager(this IConfigurationBuilder builder)
        {
            var build = builder.Build();
            var options = build.GetAWSOptions("AWS:SystemManager");
            builder.AddSystemsManager("/Davi", options, optional: true);
            builder.AddSystemsManager("/Davi/Parameter", options, optional: true, reloadAfter: TimeSpan.FromMinutes(1));


        }
    }
}
