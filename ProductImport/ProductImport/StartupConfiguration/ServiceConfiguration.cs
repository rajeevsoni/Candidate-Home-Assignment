using Microsoft.Extensions.DependencyInjection;
using ProductImport.ImportService;
using ProductImport.ImportService.Interfaces;
using ProductImport.Models;
using System;

namespace ProductImport.StartupConfiguration
{
    static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            //register dependencies here
            services.AddTransient<JSONFileParserStrategy>();
            services.AddTransient<YAMLFileParserStrategy>();

            services.AddTransient<Func<FileType, IFileParserStrategy>>(
                ServiceProvider => key =>
                {
                    switch (key)
                    {
                        case FileType.json: return ServiceProvider.GetService<JSONFileParserStrategy>();
                        case FileType.yaml: return ServiceProvider.GetService<YAMLFileParserStrategy>();
                        default: return null;

                    }
                }
                );

            services.AddTransient<FileParserContext>();
        }
    }
}
