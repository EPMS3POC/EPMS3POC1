using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ConditionBySextant
    {
        public ConditionBySextant()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long ConditionBySextantId { get; set; }
        public string ConditionBySextantDescription { get; set; }
        public string ConditionBySextantCode { get; set; }
        public string ConditionBySextantName { get; set; }
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
