using MvcFinalTest.Models;
using MvcFinalTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFinalTest.Controllers
{
    public class JobTypeController : Controller
    {
        //
        // GET: /JobType/

        private IJobTypeService service = new JobTypeService();

        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(JobTypeModel JobType)
        {
            service.Add(JobType);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            JobTypeModel JobType = service.GetJobTypeById(id);
            return View(JobType);
        }

        [HttpPost]
        public ActionResult Edit(JobTypeModel JobType)
        {
            service.Edit(JobType);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
