using MvcFinalTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcFinalTest.Service
{
    public interface IJobTypeService
    {
        Collection<JobTypeModel> GetAll();

        void Add(JobTypeModel model);

        JobTypeModel GetJobTypeById(int jobTypeId);

        void Delete(int jobTypeId);

        void Edit(JobTypeModel model);
    }
}
