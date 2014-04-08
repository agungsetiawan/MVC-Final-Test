using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFinalTest.Data;

namespace MvcFinalTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Agung Setiawan - MVC Final Project";

            // Initialize the model data
            BranchRepository.Initialize();
            JobTypeRepository.Initialize();
            EmployeeRepository.Initialize();

            return View();
        }
    }
}
