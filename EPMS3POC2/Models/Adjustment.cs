using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Adjustment
    {
        public long AdjustmentId { get; set; }
        public long TransactionId { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public long? AdjustmentCodeId { get; set; }
        public long? ProviderId { get; set; }
        public string AdjustmentReference { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public string AdjustmentComments { get; set; }
        public long? AdjustmentTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public AdjustmentCode AdjustmentCode { get; set; }
        public AdjustmentType AdjustmentType { get; set; }
        public Provider Provider { get; set; }
        public Transaction Transaction { get; set; }
    }
}
