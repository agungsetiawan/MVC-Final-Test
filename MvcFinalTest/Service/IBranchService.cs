using MvcFinalTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcFinalTest.Service
{
    public interface IBranchService
    {
        Collection<BranchModel> GetAll();

        void Add(BranchModel model);

        BranchModel GetBranchById(int branchId);

        void Delete(int branchId);

        void Edit(BranchModel model);
    }
}
