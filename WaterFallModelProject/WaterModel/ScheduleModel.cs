using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFallModelProject
{
   public class ScheduleModel
    {
        public int ScheduleId { get; set; }
        public Nullable<int> SampleId { get; set; }
        public string SampleLocation { get; set; }
        public Nullable<int> FrequencyDays { get; set; }
        public Nullable<int> FrequencyNumber { get; set; }
        public string SampleType { get; set; }
        public string ScheduleDate { get; set; }
        public string SampleName { get; set; }

        public string CreatedBy { get; set; }
        public string createdDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
