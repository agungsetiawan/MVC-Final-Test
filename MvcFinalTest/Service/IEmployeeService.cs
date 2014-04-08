using MvcFinalTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcFinalTest.Service
{
    public interface IEmployeeService
    {
        Collection<EmployeeModel> GetAll();

        void Add(EmployeeModel model);

        EmployeeModel GetEmployeeById(int employeeId);

        void Delete(int employeeId);

        void Edit(EmployeeModel model);

        List<EmployeeModel> Search(string firstName);
    }
}
