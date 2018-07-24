using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class AdjustmentCode
    {
        public AdjustmentCode()
        {
            Adjustment = new HashSet<Adjustment>();
        }

        public long AdjustmentCodeId { get; set; }
        public string AdjustmentCodeDescription { get; set; }
        public string AdjustmentCodeCode { get; set; }
        public string AdjustmentCodeName { get; set; }
        public long? AdjustmentTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public AdjustmentType AdjustmentType { get; set; }
        public ICollection<Adjustment> Adjustment { get; set; }
    }
}
