using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFallModelProject
{
  public  class AdminTestGroupingModel
    {
        public int TestGroupId { get; set; }
        public string TestGroupName { get; set; }
        public string TestGroupDescription { get; set; }
        public string SelectedIds { get; set; }
        public string MappedSampleIdToTestGroup { get; set; }
        public string CreatedBy { get; set; }
        public string createdDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
