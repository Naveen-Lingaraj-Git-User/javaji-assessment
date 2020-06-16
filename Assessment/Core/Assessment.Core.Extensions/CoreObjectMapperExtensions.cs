using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core.Extensions
{
    public static class CoreObjectMapperExtensions
    {
        public static IServiceCollection AddCoreObjectMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(new[] { "Assessment.Core.DTOs", "Assessment.Core.Entities" });
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
