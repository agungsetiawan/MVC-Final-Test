using MvcFinalTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFinalTest.Service
{
    public class EmployeeService : IEmployeeService
    {
        public System.Collections.ObjectModel.Collection<Models.EmployeeModel> GetAll()
        {
            return EmployeeRepository.GetAll();
        }

        public void Add(Models.EmployeeModel model)
        {
            EmployeeRepository.Add(model);
        }

        public Models.EmployeeModel GetEmployeeById(int employeeId)
        {
            return EmployeeRepository.GetEmployeeById(employeeId);
        }

        public void Delete(int employeeId)
        {
            EmployeeRepository.Delete(employeeId);
        }

        public void Edit(Models.EmployeeModel model)
        {
            EmployeeRepository.Edit(model);
        }

        public List<Models.EmployeeModel> Search(string firstName)
        {
            return EmployeeRepository.Search(firstName);
        }
    }
}