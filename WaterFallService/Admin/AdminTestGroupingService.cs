using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.Admin;

namespace WaterFallService.Admin
{
  public  class AdminTestGroupingService
    {
        AdminTestGroupingRepository repo = new AdminTestGroupingRepository();
        public List<AdminTestGroupingModel> GetAdminTestGroupingDetails()
        {
            return repo.GetAdminTestGroupingDetails();
        }
        public AdminTestGroupingModel GetAdminTestGroupingDetailsById(int Id)
        {
            return repo.GetAdminTestGroupingDetailsById(Id);
        }
        public bool AdminTestGroupingUpdate(int Id, AdminTestGroupingModel model)
        {
            return repo.AdminTestGroupingUpdate(Id, model);
        }
        public bool AdminTestGroupingInsert(AdminTestGroupingModel model)
        {
            return repo.AdminTestGroupingInsert(model);
        }
        public bool AdminTestGroupingRemove(int Id)
        {
            return repo.AdminTestGroupingRemove(Id);
        }
    }
}
