using Assessment.Core.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Assessment.Core.Extensions
{
    using static BaseController;
    using static BaseServiceProvider;
    public static class CoreServiceProviderExtensions
    {
        public static IServiceProvider AddCoreServiceProvider(this IServiceCollection serviceCollection)
        {
            var serviceProvider = serviceCollection.BuildServiceProvider();
            InitBaseController(serviceProvider);
            InitBaseServiceProvider(serviceProvider);
            return serviceProvider;
        }
    }
}
