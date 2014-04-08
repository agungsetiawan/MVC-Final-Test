﻿using MvcFinalTest.Models;
using MvcFinalTest.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFinalTest.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        private IEmployeeService service = new EmployeeService();
        private IBranchService branchService = new BranchService();
        private IJobTypeService jobTypeService = new JobTypeService();

        public ActionResult Index()
        {
            return View(service.GetAll());
        }

        public ActionResult Create()
        {
            List<SelectListItem> Branches = new List<SelectListItem>();
            List<SelectListItem> JobTypes = new List<SelectListItem>();

            Collection<Models.BranchModel> BranchesFromDb = branchService.GetAll();
            Collection<Models.JobTypeModel> JobTypesFromDb = jobTypeService.GetAll();

            foreach (var b in BranchesFromDb)
            {
                Branches.Add(new SelectListItem() { Text = b.Name, Value = b.BranchId.ToString() });
            }

            foreach (var j in JobTypesFromDb)
            {
                JobTypes.Add(new SelectListItem() { Text = j.Name, Value = j.JobTypeId.ToString() });
            }

            ViewBag.Branches = Branches;
            ViewBag.JobTypes = JobTypes;
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel employee, string Branches, string JobTypes)
        {
            employee.BranchId = int.Parse(Branches);
            employee.JobTypeId = int.Parse(JobTypes);

            service.Add(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            
            EmployeeModel employee = service.GetEmployeeById(id);

            List<SelectListItem> Branches = new List<SelectListItem>();
            List<SelectListItem> JobTypes = new List<SelectListItem>();

            Collection<Models.BranchModel> BranchesFromDb = branchService.GetAll();
            Collection<Models.JobTypeModel> JobTypesFromDb = jobTypeService.GetAll();

            foreach (var b in BranchesFromDb)
            {
                Branches.Add(new SelectListItem() { Text = b.Name, Value = b.BranchId.ToString(),
                Selected=b.BranchId==employee.BranchId? true : false
                });
            }

            foreach (var j in JobTypesFromDb)
            {
                JobTypes.Add(new SelectListItem() { Text = j.Name, Value = j.JobTypeId.ToString(),
                Selected=j.JobTypeId==employee.JobTypeId? true : false});
            }

            ViewBag.Branches = Branches;
            ViewBag.JobTypes = JobTypes;

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel employee, string Branches, string JobTypes)
        {
            employee.BranchId = int.Parse(Branches);
            employee.JobTypeId = int.Parse(JobTypes);

            service.Edit(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        //[NonAction]
        //public void PopulateDropDown()
        //{
        //    List<SelectListItem> Branches = new List<SelectListItem>();
        //    List<SelectListItem> JobTypes = new List<SelectListItem>();

        //    Collection<Models.BranchModel> BranchesFromDb = branchService.GetAll();
        //    Collection<Models.JobTypeModel> JobTypesFromDb = jobTypeService.GetAll();

        //    foreach (var b in BranchesFromDb)
        //    {
        //        Branches.Add(new SelectListItem() { Text = b.Name, Value = b.BranchId.ToString() });
        //    }

        //    foreach (var j in JobTypesFromDb)
        //    {
        //        JobTypes.Add(new SelectListItem() { Text = j.Name, Value = j.JobTypeId.ToString() });
        //    }

        //    ViewBag.Branches = Branches;
        //    ViewBag.JobTypes = JobTypes;
        //}

    }
}