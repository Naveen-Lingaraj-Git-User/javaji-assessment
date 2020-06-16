using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Core.Abstractions;
using Assessment.Core.Interfaces;
using Assessment.Core.Services;
using Assessment.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assessment.Presentation.WebApp.Controllers
{
    public class NewJobApplicationController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateNewJobApplication(JobApplicationViewModel jobApplicationViewModel)
        {
            jobApplicationViewModel.Result[0].ReferenceId = Guid.NewGuid();
            Using<IJobApplicationService>().CreateJobApplication(jobApplicationViewModel);
            return RedirectToAction("Index", "ApplicationList");
        }
    }
}
