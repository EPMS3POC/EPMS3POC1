using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ConditionsOnAllTeeth
    {
        public ConditionsOnAllTeeth()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long ConditionsOnAllTeethId { get; set; }
        public string ConditionsOnAllTeethDescription { get; set; }
        public string ConditionsOnAllTeethCode { get; set; }
        public string ConditionsOnAllTeethName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PerioChart> PerioChart { get; set; }
    }
}
