using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;

namespace WaterFallRepository.Admin
{
   public class AdminTestGroupingRepository
    {
        WaterFallProjectEntities2 dbcontext = new WaterFallProjectEntities2();

        public List<AdminTestGroupingModel> GetAdminTestGroupingDetails()
        {
            var data = (from p in dbcontext.TblTestGroupings
                        select new AdminTestGroupingModel
                        {
                            MappedSampleIdToTestGroup = p.MappedSampleIdToTestGroup,
                            SelectedIds = p.SelectedIds,
                            TestGroupDescription = p.TestGroupDescription,
                            TestGroupId = p.TestGroupId,
                            TestGroupName = p.TestGroupName,
                            CreatedBy = p.CreatedBy,
                            createdDate = p.createdDate,
                            ModifiedBy = p.ModifiedBy,
                            ModifiedDate = p.ModifiedDate
                        }).ToList();
            return data;
        }
        public AdminTestGroupingModel GetAdminTestGroupingDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblTestGroupings.Where(x => x.TestGroupId == Id)
                        select new AdminTestGroupingModel
                        {
                           MappedSampleIdToTestGroup=p.MappedSampleIdToTestGroup,
                           SelectedIds=p.SelectedIds,
                          TestGroupDescription=p.TestGroupDescription,
                          TestGroupId=p.TestGroupId,
                          TestGroupName=p.TestGroupName,
                          CreatedBy=p.CreatedBy,
                          createdDate=p.createdDate,
                          ModifiedBy=p.ModifiedBy,
                          ModifiedDate=p.ModifiedDate
                        }).FirstOrDefault();
            return data;
        }
        public bool AdminTestGroupingUpdate(int Id, AdminTestGroupingModel model)
        {
            var data = (from p in dbcontext.TblTestGroupings.Where(x => x.TestGroupId == Id) select p).FirstOrDefault();
           // TblTestGrouping obj = new TblTestGrouping();
            //obj.TestGroupId = model.TestGroupId;
            data.TestGroupDescription = model.TestGroupDescription;
            data.TestGroupName = model.TestGroupName;
            data.SelectedIds = model.SelectedIds;
            data.MappedSampleIdToTestGroup = model.MappedSampleIdToTestGroup;
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedDate = DateTime.Now.ToString();


            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestGroupingInsert(AdminTestGroupingModel model)
        {
            TblTestGrouping obj = new TblTestGrouping();
            obj.TestGroupId = model.TestGroupId;
            obj.TestGroupDescription = model.TestGroupDescription;
            obj.TestGroupName = model.TestGroupName;
            obj.SelectedIds = model.SelectedIds;
            obj.MappedSampleIdToTestGroup = model.MappedSampleIdToTestGroup;
            obj.CreatedBy = model.CreatedBy;
            obj.createdDate = DateTime.Now.ToString();
            obj.ModifiedBy = model.ModifiedBy;
            obj.ModifiedDate = DateTime.Now.ToString();

            dbcontext.TblTestGroupings.Add(obj);
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestGroupingRemove(int Id)
        {
            var data = (from p in dbcontext.TblTestGroupings.Where(x => x.TestGroupId == Id) select p).FirstOrDefault();
            dbcontext.TblTestGroupings.Remove(data);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
