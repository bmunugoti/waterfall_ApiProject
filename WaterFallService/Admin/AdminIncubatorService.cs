using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.Admin;


namespace WaterFallService.Admin
{
  public  class AdminIncubatorService
    {
        AdminIncubatorRepository repo = new AdminIncubatorRepository();
        public List<AdminIncubatorModel> GetAdminIncubatorDetails()
        {
            return repo.GetAdminIncubatorDetails();
        }
        public AdminIncubatorModel GetAdminIncubatorDetailsById(int Id)
        {
            return repo.GetAdminIncubatorDetailsById(Id);
        }
        public bool AdminIncubatorUpdate(int Id, AdminIncubatorModel model)
        {
            return repo.AdminIncubatorUpdate(Id, model);
        }
        public bool AdminIncubatorIndert(AdminIncubatorModel model)
        {
            return repo.AdminIncubatorInsert(model);
        }
        public bool AdminIncubatorRemove(int Id)
        {
            return repo.AdminIncubatorRemove(Id);
        }
    }
}
