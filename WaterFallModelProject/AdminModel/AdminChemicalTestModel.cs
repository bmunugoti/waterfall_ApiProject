using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterFallModelProject
{
   public class AdminChemicalTestModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public string TestType { get; set; }
        public string TestType1 { get; set; }
        public string TestDescription { get; set; }
        public string TestCondition { get; set; }
        public string UnitOfMeasurment { get; set; }
        public Nullable<int> TestMin { get; set; }
        public Nullable<int> TestMax { get; set; }
        public Nullable<int> TestLessthan { get; set; }
        public Nullable<int> TestGreaterThan { get; set; }
        public string TestFile { get; set; }
       
        public string LogedInUser { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
    }
}
