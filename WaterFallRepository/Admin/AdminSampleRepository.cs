using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterFallEntityProject.EntityModel;
using WaterFallModelProject;


namespace WaterFallRepository.Admin
{
   public class AdminSampleRepository
    {
        WaterFallProjectEntities2 dbcontext = new WaterFallProjectEntities2();

        public List<AdminSampleModel> GetAdminTestDetails()
        {
            var data = (from p in dbcontext.TblAdminSamples select new AdminSampleModel
            {
                Frequncy=p.Frequncy,
                Id=p.Id,
                Remarks=p.Remarks,
                SampleLocation1=p.SampleLocation1,
                SampleLocation2=p.SampleLocation2,
                SampleLocation3=p.SampleLocation3,
                SampleLocation4=p.SampleLocation4,
                SampleName=p.SampleName,
                SampleType=p.SampleType,
                SelectFrequncy=p.SelectFrequncy,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                LogedInUser = p.LogedInUser,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate
            }).ToList();
            return data;
        }
        public AdminSampleModel GetAdminTestDetailsById(int Id)
        {
            var data = (from p in dbcontext.TblAdminSamples.Where(x => x.Id == Id) select new AdminSampleModel
            {
                Frequncy = p.Frequncy,
                Id = p.Id,
                Remarks = p.Remarks,
                SampleLocation1 = p.SampleLocation1,
                SampleLocation2 = p.SampleLocation2,
                SampleLocation3 = p.SampleLocation3,
                SampleLocation4 = p.SampleLocation4,
                SampleName = p.SampleName,
                SampleType = p.SampleType,
                SelectFrequncy = p.SelectFrequncy,
                CreatedBy = p.CreatedBy,
                CreatedDate = p.CreatedDate,
                LogedInUser = p.LogedInUser,
                ModifiedBy = p.ModifiedBy,
                ModifiedDate = p.ModifiedDate
            }).FirstOrDefault();
            return data;
        }
        public bool AdminTestUpdate(int Id, AdminSampleModel model)
        {
            var data = (from p in dbcontext.TblAdminSamples.Where(x => x.Id == Id) select p).FirstOrDefault();
            data.Frequncy = model.Frequncy;
            data.Remarks = model.Remarks;
            data.SampleLocation1 = model.SampleLocation1;
            data.SampleLocation2 = model.SampleLocation2;
            data.SampleLocation3 = model.SampleLocation3;
            data.SampleLocation4 = model.SampleLocation4;
            data.SampleName = model.SampleName;
            data.SampleType = model.SampleType;
            data.SelectFrequncy = model.SelectFrequncy;
            //data.CreatedBy = model.CreatedBy;
           // data.CreatedDate = model.CreatedDate;
            data.LogedInUser = model.LogedInUser;
            data.ModifiedBy = model.ModifiedBy;
            data.ModifiedDate = DateTime.Now.ToString();

            var objschedule = (from p in dbcontext.TblSchedules.Where(x => x.SampleId == Id) select p).FirstOrDefault();
           
           
            objschedule.SampleLocation = model.SampleLocation4;
            objschedule.SampleType = model.SampleType;
            objschedule.SampleName = model.SampleName;

            // objschedule.ScheduleDate = DateTime.Now.ToString();
            objschedule.SampleName = model.SampleName;
            objschedule.CreatedBy = model.CreatedBy;
            objschedule.createdDate = DateTime.Now.ToString();

            objschedule.ModifiedBy = model.ModifiedBy;
            objschedule.ModifiedDate = DateTime.Now.ToString();
           

            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestInsert(AdminSampleModel model)
        {
            TblAdminSample obj = new TblAdminSample();
            obj.Frequncy = model.Frequncy;
            obj.Remarks = model.Remarks;
            obj.SampleLocation1 = model.SampleLocation1;
            obj.SampleLocation2 = model.SampleLocation2;
            obj.SampleLocation3 = model.SampleLocation3;
            obj.SampleLocation4 = model.SampleLocation4;
            obj.SampleName = model.SampleName;
            obj.SampleType = model.SampleType;
            obj.SelectFrequncy = model.SelectFrequncy;
            obj.CreatedBy = model.CreatedBy;
            obj.CreatedDate = DateTime.Now.ToString();
            obj.LogedInUser = model.LogedInUser;
            obj.ModifiedBy = model.ModifiedBy;
            obj.ModifiedDate = DateTime.Now.ToString();

                        dbcontext.TblAdminSamples.Add(obj);
            dbcontext.SaveChanges();
            int id = obj.Id;
            TblSchedule objschedule = new TblSchedule();
            objschedule.SampleId = id;
            objschedule.FrequencyDays = null;
            objschedule.FrequencyNumber =null;
            //objschedule.SampleId = model.Id;
            objschedule.SampleLocation = model.SampleLocation4;
            objschedule.SampleType = model.SampleType;
            objschedule.ScheduleDate = DateTime.Now.ToString();
            objschedule.SampleName = model.SampleName;
            objschedule.CreatedBy = model.CreatedBy;
            objschedule.createdDate = DateTime.Now.ToString();
            objschedule.SampleName = model.SampleName;
            objschedule.ModifiedBy = model.ModifiedBy;
            objschedule.ModifiedDate = DateTime.Now.ToString();
            dbcontext.TblSchedules.Add(objschedule);
            dbcontext.SaveChanges();
            return true;
        }
        public bool AdminTestRemove(int Id)
        {
            var data = (from p in dbcontext.TblAdminSamples.Where(x => x.Id == Id) select p).FirstOrDefault();
            var scheduledata = (from p in dbcontext.TblSchedules.Where(x => x.SampleId == data.Id) select p).FirstOrDefault();
            dbcontext.TblAdminSamples.Remove(data);
            dbcontext.TblSchedules.Remove(scheduledata);
            dbcontext.SaveChanges();
            return true;
        }
    }
}
