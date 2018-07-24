using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AdjustmentType
    {
        public AdjustmentType()
        {
            Adjustment = new HashSet<Adjustment>();
            AdjustmentCode = new HashSet<AdjustmentCode>();
        }

        public long AdjustmentTypeId { get; set; }
        public string AdjustmentTypeCode { get; set; }
        public string AdjustmentTypeName { get; set; }
        public string AdjustmentTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Adjustment> Adjustment { get; set; }
        public ICollection<AdjustmentCode> AdjustmentCode { get; set; }
    }
}
