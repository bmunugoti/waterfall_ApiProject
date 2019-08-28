using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.Admin;


namespace WaterFallService.Admin
{
   public class AdminChemicalTestService
    {
        AdminTestRepository repo = new AdminTestRepository();
        public List<AdminChemicalTestModel> GetAdminTestDetails()
        {
            return repo.GetAdminTestDetails();
        }
        public AdminChemicalTestModel GetAdminTestDetailsById(int Id)
        {
            return repo.GetAdminTestDetailsById(Id);
        }
        public bool AdminTestUpdate(int Id, AdminChemicalTestModel model)
        {
            return repo.AdminTestUpdate(Id, model);
        }
        public bool AdminTestInsert(AdminChemicalTestModel model)
        {
            return repo.AdminTestInsert(model);
        }
        public bool AdminTestRemove(int Id)
        {
            return repo.AdminTestRemove(Id);
        }
    }
}
