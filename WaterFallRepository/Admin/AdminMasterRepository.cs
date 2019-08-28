using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;


namespace WaterFallRepository.Admin
{
    public class AdminMasterRepository
    {
      //  WaterFallProjectEntities2 dbcontext=new WaterFallProjectEntities2();
        WaterFallProjectEntities2 dbcontext;
        
        public AdminMasterRepository(WaterFallProjectEntities2 _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public List<AdminModel> GetAdminMaterDetails()
        {
            var data = (from p in dbcontext.TblAdminMasters select new AdminModel
            {
                Admin1=p.Admin1,
                Admin2=p.Admin2,
                Admin3=p.Admin3,
                Admin4=p.Admin4,
                Admin5=p.Admin5,
                Description=p.Description,
                Id=p.Id,
                Name=p.Name
            }).ToList();
            return data;
        }
        public AdminModel GetAdminMaterDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblAdminMasters.Where(x=>x.Id==Id) select new AdminModel
            {
                Admin1 = p.Admin1,
                Admin2 = p.Admin2,
                Admin3 = p.Admin3,
                Admin4 = p.Admin4,
                Admin5 = p.Admin5,
                Description = p.Description,
                Id = p.Id,
                Name = p.Name
            }).FirstOrDefault();
            return data;
        }
        public bool AdminUpdate(int Id, AdminModel model)
        {
            var data = (from p in dbcontext.TblAdminMasters.Where(x => x.Id == Id) select p).FirstOrDefault();
            data.Admin1 = model.Admin1;
            data.Admin2 = model.Admin2;
            data.Admin3 = model.Admin3;
            data.Admin4 = model.Admin4;
            data.Admin5 = model.Admin5;
            data.Description = model.Description;
            data.Name = model.Name;
            
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminInsert(AdminModel model)
        {
            TblAdminMaster obj = new TblAdminMaster();
            obj.Admin1 = model.Admin1;
            obj.Admin2 = model.Admin2;
            obj.Admin3 = model.Admin3;
            obj.Admin4 = model.Admin4;
            obj.Admin5 = model.Admin5;
            obj.Description = model.Description;
            obj.Name = model.Name;
            
            dbcontext.TblAdminMasters.Add(obj);
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminRemove(int Id)
        {
            var data = (from p in dbcontext.TblAdminMasters.Where(x => x.Id == Id) select p).FirstOrDefault();
            dbcontext.TblAdminMasters.Remove(data);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
