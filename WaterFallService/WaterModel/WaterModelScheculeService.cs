using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallModelProject;
using WaterFallRepository.WaterFall;

namespace WaterFallService.WaterModel
{
   public class WaterModelScheculeService
    {
        WaterModelScheduleRepository repo = new WaterModelScheduleRepository();
        public List<ScheduleModel> GetWaterModelScheduleDetails()
        {
            return repo.GetWaterModelScheduleDetails();
        }
        public ScheduleModel GetWaterModelScheduleDetailsById(int Id)
        {
            return repo.GetWaterModelScheduleDetailsById(Id);
        }
        public bool WaterModelScheduleUpdate(int Id, ScheduleModel model)
        {
            return repo.WaterModelScheduleUpdate(Id, model);
        }
        public bool WaterModelScheduleInsert(List<ScheduleModel> model)
        {
            return repo.WaterModelScheduleInsert(model);
        }
        public bool WaterModelScheduleRemove(int Id)
        {
            return repo.WaterModelScheduleRemove(Id);
        }
    }
}
