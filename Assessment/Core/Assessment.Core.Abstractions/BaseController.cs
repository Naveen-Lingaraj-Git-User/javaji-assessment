using System;
using System.Collections.Generic;
using System.Text;
using Assessment.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment.Core.Abstractions
{
    public class BaseController : Controller
    {
        private static IServiceProvider CoreServiceProvider { get; set; }
        public static void InitBaseController(IServiceProvider serviceProvider)
        {
            CoreServiceProvider = serviceProvider;

            // Make sure that the in-memory db is created.
            CoreServiceProvider.GetService<AssessmentDbContext>().Database.EnsureCreated();
        }
        protected T Using<T>()
        {
            return CoreServiceProvider.GetService<T>();
        }
    }
}
