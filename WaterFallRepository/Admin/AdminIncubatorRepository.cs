using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;


namespace WaterFallRepository.Admin
{
    public class AdminIncubatorRepository
    {
        WaterFallProjectEntities2 dbcontext = new WaterFallProjectEntities2();

        public List<AdminIncubatorModel> GetAdminIncubatorDetails()
        {
            var data = (from p in dbcontext.TblAdminIncubators select new AdminIncubatorModel
            {
                IncubatorDescription=p.IncubatorDescription,
                IncubatorId=p.IncubatorId,
                IncubatorName=p.IncubatorName,
                CreatedBy=p.CreatedBy,
                CreatedDate=p.CreatedDate,
                LogedInUser=p.LogedInUser,
              ModifiedBy=p.ModifiedBy,
              ModifiedDate=p.ModifiedDate  
            }).ToList();
            return data;
        }
        public AdminIncubatorModel GetAdminIncubatorDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblAdminIncubators.Where(x => x.IncubatorId == Id) select new AdminIncubatorModel {
                IncubatorDescription = p.IncubatorDescription,
                IncubatorId = p.IncubatorId,
                IncubatorName = p.IncubatorName,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                LogedInUser = p.LogedInUser,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate
            }).FirstOrDefault();
            return data;
        }
        public bool AdminIncubatorUpdate(int Id, AdminIncubatorModel model)
        {
            var data = (from p in dbcontext.TblAdminIncubators.Where(x => x.IncubatorId == Id) select p).FirstOrDefault();
            data.IncubatorDescription = model.IncubatorDescription;
            data.IncubatorName = model.IncubatorName;
            //data.CreatedBy = model.CreatedBy;
            //data.CreatedDate = model.CreatedDate;
            data.LogedInUser = model.LogedInUser;
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedDate = DateTime.Now.ToString();


            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminIncubatorInsert(AdminIncubatorModel model)
        {
            TblAdminIncubator obj = new TblAdminIncubator();
            obj.IncubatorDescription = model.IncubatorDescription;
            obj.IncubatorName = model.IncubatorName;
            obj.CreatedBy = model.CreatedBy;
            obj.CreatedDate = DateTime.Now.ToString();
            obj.LogedInUser = model.LogedInUser;
            obj.ModifiedBy = model.ModifiedBy;
            obj.ModifiedDate = DateTime.Now.ToString();

            dbcontext.TblAdminIncubators.Add(obj);
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminIncubatorRemove(int Id)
        {
            var data = (from p in dbcontext.TblAdminIncubators.Where(x => x.IncubatorId == Id) select p).FirstOrDefault();
            dbcontext.TblAdminIncubators.Remove(data);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
