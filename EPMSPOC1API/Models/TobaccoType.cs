using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TobaccoType
    {
        public TobaccoType()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long TobaccoTypeId { get; set; }
        public string TobaccoTypeDescription { get; set; }
        public string TobaccoTypeCode { get; set; }
        public string TobaccoTypeName { get; set; }
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
