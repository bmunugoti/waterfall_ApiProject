using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFallModelProject
{
   public class AdminSampleModel
    {
        public int Id { get; set; }
        public string SampleLocation1 { get; set; }
        public string SampleLocation2 { get; set; }
        public string SampleLocation3 { get; set; }
        public string SampleLocation4 { get; set; }
        public string SampleName { get; set; }
        public string SampleType { get; set; }
        public string Frequncy { get; set; }
        public string Remarks { get; set; }
        public string SelectFrequncy { get; set; }

       
        public string LogedInUser { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
