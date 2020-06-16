using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Core.Abstractions;
using Assessment.Core.Interfaces;
using Assessment.Core.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Presentation.WebApp.Controllers
{
    public class ApplicationListController : BaseController
    {
        public IActionResult Index()
        {
            return View(Using<IJobApplicationService>().ReadJobApplications());
        }
    }
}
