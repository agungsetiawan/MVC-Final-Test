using MvcFinalTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFinalTest.Service
{
    public class BranchService : IBranchService
    {
        public System.Collections.ObjectModel.Collection<Models.BranchModel> GetAll()
        {
            return BranchRepository.GetAll();
        }

        public void Add(Models.BranchModel model)
        {
            BranchRepository.Add(model);
        }

        public Models.BranchModel GetBranchById(int branchId)
        {
            return BranchRepository.GetBranchById(branchId);
        }

        public void Delete(int branchId)
        {
            BranchRepository.Delete(branchId);
        }

        public void Edit(Models.BranchModel model)
        {
            BranchRepository.Edit(model);
        }
    }
}