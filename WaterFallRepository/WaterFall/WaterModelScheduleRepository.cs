using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;

namespace WaterFallRepository.WaterFall
{
   public class WaterModelScheduleRepository
    {
        WaterFallProjectEntities2 dbcontext = new WaterFallProjectEntities2();

        public List<ScheduleModel> GetWaterModelScheduleDetails()
        {
            var data = (from p in dbcontext.TblSchedules
                        select new ScheduleModel
                        {
                            SampleName=p.SampleName,
                           FrequencyDays=p.FrequencyDays,
                           FrequencyNumber=p.FrequencyNumber,
                           SampleId=p.SampleId,
                           ScheduleId=p.ScheduleId,
                           SampleLocation=p.SampleLocation,
                           SampleType=p.SampleType,
                           ScheduleDate=p.ScheduleDate,
                            CreatedBy = p.CreatedBy,
                            createdDate = p.createdDate,
                            ModifiedBy = p.ModifiedBy,
                            ModifiedDate = p.ModifiedDate
                        }).ToList();
            return data;
        }
        public ScheduleModel GetWaterModelScheduleDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblSchedules.Where(x => x.ScheduleId == Id)
                        select new ScheduleModel
                        {
                            SampleName=p.SampleName,
                            FrequencyDays = p.FrequencyDays,
                            FrequencyNumber = p.FrequencyNumber,
                            SampleId = p.SampleId,
                            ScheduleId = p.ScheduleId,
                            SampleLocation = p.SampleLocation,
                            SampleType = p.SampleType,
                            ScheduleDate = p.ScheduleDate,
                            CreatedBy = p.CreatedBy,
                            createdDate = p.createdDate,
                            ModifiedBy = p.ModifiedBy,
                            ModifiedDate = p.ModifiedDate
                        }).FirstOrDefault();
            return data;
        }
        public bool WaterModelScheduleUpdate(int Id, ScheduleModel model)
        {
            var data = (from p in dbcontext.TblSchedules.Where(x => x.ScheduleId == Id) select p).FirstOrDefault();
            // TblTestGrouping obj = new TblTestGrouping();
            //obj.TestGroupId = model.TestGroupId;
             data.FrequencyDays = model.FrequencyDays;
             data.FrequencyNumber = model.FrequencyNumber;
             data.SampleId = model.SampleId;
             //data.ScheduleId = model.ScheduleId;
             data.SampleLocation = model.SampleLocation;
             data.SampleType = model.SampleType;
            data.ScheduleDate = model.ScheduleDate;
                            
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedDate = DateTime.Now.ToString();


            dbcontext.SaveChanges();
            return true;
        }
        public bool WaterModelScheduleInsert(List<ScheduleModel> lstmodel)
        {
           
           
            foreach(var model in lstmodel)
            {
                var data = (from p in dbcontext.TblSchedules.Where(x => x.ScheduleId == model.ScheduleId) select p).FirstOrDefault();
                dbcontext.TblSchedules.Remove(data);
                dbcontext.SaveChanges();
                TblSchedule obj = new TblSchedule();
                obj.FrequencyDays = model.FrequencyDays;
                obj.FrequencyNumber = model.FrequencyNumber;
                obj.SampleId = model.SampleId;
                obj.SampleName = model.SampleName;
                obj.SampleLocation = model.SampleLocation;
                obj.SampleType = model.SampleType;
                obj.ScheduleDate = model.ScheduleDate;
                obj.CreatedBy = model.CreatedBy;
                obj.createdDate = DateTime.Now.ToString();
                obj.ModifiedBy = model.ModifiedBy;
                obj.ModifiedDate = DateTime.Now.ToString();
                dbcontext.TblSchedules.Add(obj);
                TblActivity objAct = new TblActivity();
                objAct.FrequencyDays = model.FrequencyDays;
                objAct.FrequencyNumber = model.FrequencyNumber;
                objAct.SampleId = model.SampleId;
                objAct.SampleLocation = model.SampleLocation;
                objAct.SampleType = model.SampleType;
                //objAct.ScheduleDate = model.ScheduleDate.ToString() ;
                objAct.AcceptedReject = 0;
                objAct.DeactivatedReason = "";
                objAct.EndDate = DateTime.Now;
                objAct.StartDate = DateTime.Now;
                objAct.ScheduleDate = model.ScheduleDate;
                dbcontext.TblActivities.Add(objAct);
            }
           
            dbcontext.SaveChanges();
            return true;
        }
        public bool WaterModelScheduleRemove(int Id)
        {
            var data = (from p in dbcontext.TblSchedules.Where(x => x.ScheduleId == Id) select p).FirstOrDefault();
            dbcontext.TblSchedules.Remove(data);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
