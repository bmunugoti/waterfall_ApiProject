using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.Admin;


namespace WaterFallService.Admin
{
    public class AdminMasterService
    {
        AdminMasterRepository repo ;
        
        public AdminMasterService(AdminMasterRepository _repo)
        {
            repo = _repo;
        }
        public List<AdminModel> GetAdminMaterDetails()
        {
            return repo.GetAdminMaterDetails();
        }
        public AdminModel GetAdminMaterDetailsById(int Id)
        {
            return repo.GetAdminMaterDetailsById(Id);
        }
        public bool AdminUpdate(int Id,AdminModel model)
        {
            return repo.AdminUpdate(Id,model);
        }
        public bool AdminIndert( AdminModel model)
        {
            return repo.AdminInsert( model);
        }
        public bool AdminRemove(int Id)
        {
            return repo.AdminRemove(Id);
        }
    }
}
