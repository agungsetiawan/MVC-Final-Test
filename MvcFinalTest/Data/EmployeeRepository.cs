using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcFinalTest.Models;
using System.Collections.ObjectModel;

namespace MvcFinalTest.Data
{
    public static class EmployeeRepository
    {
        private static Collection<EmployeeModel> _employees;
        private static int EmployeeIdIncrement = 1;

        public static void Initialize()
        {
            _employees = new Collection<EmployeeModel>();                
        }

        public static Collection<EmployeeModel> GetAll()
        {
            foreach (var item in _employees)
            {
                item.Branch = BranchRepository.GetBranchById(item.BranchId).Name;
                item.JobType = JobTypeRepository.GetJobTypeById(item.JobTypeId).Name;
            }
            return _employees;
        }

        public static void Add(EmployeeModel model)
        {
            model.EmployeeId = EmployeeIdIncrement;
            EmployeeIdIncrement += 1;

            _employees.Add(model);
        }

        public static EmployeeModel GetEmployeeById(int employeeId)
        {
            var model = _employees.Where(c => c.EmployeeId == employeeId).SingleOrDefault();
            model.Branch = BranchRepository.GetBranchById(model.BranchId).Name;
            model.JobType = JobTypeRepository.GetJobTypeById(model.JobTypeId).Name;
            return model;
        }

        public static void Delete(int employeeId)
        {
            _employees.Remove(_employees.SingleOrDefault(c => c.EmployeeId == employeeId));
        }

        public static void Edit(EmployeeModel model)
        {
            var employee = _employees.Where(c => c.EmployeeId == model.EmployeeId).SingleOrDefault();
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.Email = model.Email;
            employee.Address = model.Address;
            employee.BranchId = model.BranchId;
            employee.JobTypeId = model.JobTypeId;
        }

        public static List<EmployeeModel> Search(string firstName)
        {
            var result = _employees.Where(c => c.FirstName.ToLower().Contains(firstName.ToLower())).ToList();
            foreach (var item in result)
            {
                item.Branch = BranchRepository.GetBranchById(item.BranchId).Name;
                item.JobType = JobTypeRepository.GetJobTypeById(item.JobTypeId).Name;
            }
            return result;
        }
    }
}