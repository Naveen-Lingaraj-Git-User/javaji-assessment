using Assessment.Core.Interfaces;
using Assessment.Core.Services;
using Assessment.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Core.Extensions
{
    public static class CoreServiceExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddDbContext<AssessmentDbContext>(options => options.UseInMemoryDatabase("Assessment"));
            services.AddTransient<IJobApplicationService, JobApplicationService>();
            return services;
        }
    }
}
