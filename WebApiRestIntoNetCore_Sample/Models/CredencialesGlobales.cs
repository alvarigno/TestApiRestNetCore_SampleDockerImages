using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApiRestIntoNetCore_Sample.Models
{
    public class CredencialesGlobales
    {
        public static IConfiguration AppSetting { get; }

        static CredencialesGlobales()
        {
            AppSetting = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();
        }
    }
}
