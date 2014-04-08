using MvcFinalTest.Data;
using MvcFinalTest.Models;
using MvcFinalTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFinalTest.Controllers
{
    public class BranchController : Controller
    {
        //
        // GET: /Branch/

        private IBranchService service = new BranchService();

        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BranchModel branch)
        {
            service.Add(branch);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            BranchModel branch = service.GetBranchById(id);
            return View(branch);
        }

        [HttpPost]
        public ActionResult Edit(BranchModel branch)
        {
            service.Edit(branch);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
