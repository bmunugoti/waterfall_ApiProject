using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.Admin;


namespace WaterFallService.Admin
{
   public class AdminSampleService
    {
        AdminSampleRepository repo = new AdminSampleRepository();
        public List<AdminSampleModel> GetAdminSampleDetails()
        {
            return repo.GetAdminTestDetails();
        }
        public AdminSampleModel GetAdminSampleDetailsById(int Id)
        {
            return repo.GetAdminTestDetailsById(Id);
        }
        public bool AdminSampleUpdate(int Id, AdminSampleModel model)
        {
            return repo.AdminTestUpdate(Id, model);
        }
        public bool AdminSampleInsert(AdminSampleModel model)
        {
            return repo.AdminTestInsert(model);
        }
        public bool AdminSampleRemove(int Id)
        {
            return repo.AdminTestRemove(Id);
        }
    }
}
