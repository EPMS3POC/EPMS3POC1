using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ToothType
    {
        public ToothType()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long ToothTypeId { get; set; }
        public string ToothTypeCode { get; set; }
        public string ToothTypeName { get; set; }
        public string ToothTypeDescription { get; set; }
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
