using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFallModelProject
{
    public class AdminIncubatorModel
    {
        public int IncubatorId { get; set; }
        public string IncubatorName { get; set; }
        public string IncubatorDescription { get; set; }
      
        public string LogedInUser { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
