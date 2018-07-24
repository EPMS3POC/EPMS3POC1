using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BrushType
    {
        public BrushType()
        {
            PerioChart = new HashSet<PerioChart>();
        }

        public long BrushTypeId { get; set; }
        public string BrushTypeDescription { get; set; }
        public string BrushTypeCode { get; set; }
        public string BrushTypeName { get; set; }
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
