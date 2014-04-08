using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using MvcFinalTest.Models;

namespace MvcFinalTest.Data
{
    public class JobTypeRepository
    {
        private static Collection<JobTypeModel> _jobTypes;
        private static int jobTypeIdIncrement = 3;

        public static void Initialize()
        {
            _jobTypes = new Collection<JobTypeModel>();
            JobTypeModel b1 = new JobTypeModel() { JobTypeId = 1, Name = "Manager", RatePerHour = 50000 };
            JobTypeModel b2 = new JobTypeModel() { JobTypeId = 2, Name = "Junior Programmer", RatePerHour = 25000 };
            _jobTypes.Add(b1);
            _jobTypes.Add(b2);
        }

        public static Collection<JobTypeModel> GetAll()
        {
            return _jobTypes;
        }

        public static void Add(JobTypeModel model)
        {
            model.JobTypeId = jobTypeIdIncrement;
            jobTypeIdIncrement += 1;

            _jobTypes.Add(model);
        }

        public static JobTypeModel GetJobTypeById(int jobTypeId)
        {
            return _jobTypes.Where(c => c.JobTypeId == jobTypeId).SingleOrDefault();
        }

        public static void Delete(int jobTypeId)
        {
            _jobTypes.Remove(_jobTypes.SingleOrDefault(c => c.JobTypeId == jobTypeId));
        }

        public static void Edit(JobTypeModel model)
        {
            var jobType = _jobTypes.Where(c => c.JobTypeId == model.JobTypeId).SingleOrDefault();
            jobType.Name = model.Name;
            jobType.RatePerHour = model.RatePerHour;
        }
    }
}