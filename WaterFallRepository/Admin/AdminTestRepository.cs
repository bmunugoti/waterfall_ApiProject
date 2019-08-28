using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;


namespace WaterFallRepository.Admin
{
   public class AdminTestRepository
    {
        WaterFallProjectEntities2 dbcontext = new WaterFallProjectEntities2();

        public List<AdminChemicalTestModel> GetAdminTestDetails()
        {
            var data = (from p in dbcontext.TblAdminChemicalTests select new AdminChemicalTestModel
            {
                Id=p.Id,
                TestCondition=p.TestCondition,
                TestDescription=p.TestDescription,
                TestFile=p.TestFile,
                TestGreaterThan=p.TestGreaterThan,
                TestLessthan=p.TestLessthan,
                TestMax=p.TestMax,
                TestMin=p.TestMin,
                TestName=p.TestName,
                TestType=p.TestType,
                TestType1=p.TestType1,
                UnitOfMeasurment=p.UnitOfMeasurment,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                LogedInUser = p.LogedInUser,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate
            }).ToList();
            return data;
        }
        public AdminChemicalTestModel GetAdminTestDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblAdminChemicalTests.Where(x => x.Id == Id) select new AdminChemicalTestModel
            {
                Id = p.Id,
                TestCondition = p.TestCondition,
                TestDescription = p.TestDescription,
                TestFile = p.TestFile,
                TestGreaterThan = p.TestGreaterThan,
                TestLessthan = p.TestLessthan,
                TestMax = p.TestMax,
                TestMin = p.TestMin,
                TestName = p.TestName,
                TestType = p.TestType,
                TestType1 = p.TestType1,
                UnitOfMeasurment = p.UnitOfMeasurment,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                LogedInUser = p.LogedInUser,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate
            }).FirstOrDefault();
            return data;
        }
        public bool AdminTestUpdate(int Id, AdminChemicalTestModel model)
        {
            var data = (from p in dbcontext.TblAdminChemicalTests.Where(x => x.Id == Id) select p).FirstOrDefault();
            data.TestCondition = model.TestCondition;
            data.TestDescription = model.TestDescription;
            data.TestFile = model.TestFile;
            data.TestGreaterThan = model.TestGreaterThan;
            data.TestLessthan = model.TestLessthan;
            data.TestMax = model.TestMax;
            data.TestMin = model.TestMin;
            data.TestName = model.TestName;
            data.TestType = model.TestType;
            data.TestType1 = model.TestType1;
            data.UnitOfMeasurment = model.UnitOfMeasurment;
           // data.CreatedBy = model.CreatedBy;
           // data.CreatedDate = model.CreatedDate;
            data.LogedInUser = model.LogedInUser;
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedDate = DateTime.Now.ToString();


            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestInsert(AdminChemicalTestModel model)
        {
            TblAdminChemicalTest obj = new TblAdminChemicalTest();
            obj.TestCondition = model.TestCondition;
            obj.TestDescription = model.TestDescription;
            obj.TestFile = model.TestFile;
            obj.TestGreaterThan = model.TestGreaterThan;
            obj.TestLessthan = model.TestLessthan;
            obj.TestMax = model.TestMax;
            obj.TestMin = model.TestMin;
            obj.TestName = model.TestName;
            obj.TestType = model.TestType;
            obj.TestType1 = model.TestType1;
            obj.UnitOfMeasurment = model.UnitOfMeasurment;
            obj.CreatedBy = model.CreatedBy;
            obj.CreatedDate = DateTime.Now.ToString();
            obj.LogedInUser = model.LogedInUser;
            obj.ModifiedBy = model.ModifiedBy;
            obj.ModifiedDate = DateTime.Now.ToString();

            dbcontext.TblAdminChemicalTests.Add(obj);
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestRemove(int Id)
        {
            var data = (from p in dbcontext.TblAdminChemicalTests.Where(x => x.Id == Id) select p).FirstOrDefault();
            dbcontext.TblAdminChemicalTests.Remove(data);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
