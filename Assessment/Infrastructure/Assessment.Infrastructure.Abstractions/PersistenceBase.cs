using Assessment.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Assessment.Infrastructure.Abstractions
{
    public class PersistenceBase
    {
        private static IServiceProvider InfrastructureServiceProvider { get; set; }
        public static void InitBaseController(IServiceProvider serviceProvider)
        {
            InfrastructureServiceProvider = serviceProvider;
        }
        protected T Using<T>()
        {
            return InfrastructureServiceProvider.GetService<T>();
        }
    }
}
