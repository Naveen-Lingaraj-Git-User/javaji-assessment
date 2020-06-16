using System;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment.Core.Abstractions
{
    public class BaseServiceProvider
    {
        private static IServiceProvider CoreServiceProvider { get; set; }
        public static void InitBaseServiceProvider(IServiceProvider serviceProvider)
        {
            CoreServiceProvider = serviceProvider;
        }
        protected T Using<T>()
        {
            return CoreServiceProvider.GetService<T>();
        }
    }
}
