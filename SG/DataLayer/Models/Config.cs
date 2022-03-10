using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataLayer.Models
{
    public static class Config {
        private static IConfiguration configuration;
        static Config() {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            configuration = builder.Build();
        }

        public static string Get(string name) {
            string appSettings = configuration[name];
            return appSettings;
        }
    }
}