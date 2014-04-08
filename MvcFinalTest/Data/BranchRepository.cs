using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcFinalTest.Models;
using System.Collections.ObjectModel;

namespace MvcFinalTest.Data
{
    public static class BranchRepository
    {
        private static Collection<BranchModel> _branches;
        private static int branchIdIncrement = 3;

        public static void Initialize()
        {
            _branches = new Collection<BranchModel>(); 
            BranchModel b1 = new BranchModel(){ BranchId  = 1, Address = "Jl Kediri", Name = "Kuta", ZipCode =  "80808"};
            BranchModel b2 = new BranchModel(){ BranchId = 2, Address = "By Pass Ngurah Rai", Name = "Suwung", ZipCode = "23232"};
            _branches.Add(b1);
            _branches.Add(b2);
        }

        public static Collection<BranchModel> GetAll()
        {
            return _branches;
        }

        public static void Add(BranchModel model)
        {
            model.BranchId = branchIdIncrement;
            branchIdIncrement += 1;

            _branches.Add(model);
        }

        public static BranchModel GetBranchById(int branchId)
        {
            return _branches.Where(c => c.BranchId == branchId).SingleOrDefault();
        }

        public static void Delete(int branchId)
        {
            _branches.Remove(_branches.SingleOrDefault(c => c.BranchId == branchId));
        }

        public static void Edit(BranchModel model)
        {
            var branch = _branches.Where(c => c.BranchId == model.BranchId).SingleOrDefault();
            branch.Address = model.Address;
            branch.Name = model.Name;
            branch.ZipCode = model.ZipCode;
        }
    }
}