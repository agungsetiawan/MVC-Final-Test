using MvcFinalTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFinalTest.Service
{
    public class JobTypeService : IJobTypeService
    {
        public System.Collections.ObjectModel.Collection<Models.JobTypeModel> GetAll()
        {
            return JobTypeRepository.GetAll();
        }

        public void Add(Models.JobTypeModel model)
        {
            JobTypeRepository.Add(model);
        }

        public Models.JobTypeModel GetJobTypeById(int jobTypeId)
        {
            return JobTypeRepository.GetJobTypeById(jobTypeId);
        }

        public void Delete(int jobTypeId)
        {
            JobTypeRepository.Delete(jobTypeId);
        }

        public void Edit(Models.JobTypeModel model)
        {
            JobTypeRepository.Edit(model);
        }
    }
}