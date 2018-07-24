using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoverageType
    {
        public CoverageType()
        {
            Subscriber = new HashSet<Subscriber>();
        }

        public long CoverageTypeId { get; set; }
        public string CoverageTypeDescription { get; set; }
        public string CoverageTypeCode { get; set; }
        public string CoverageTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Subscriber> Subscriber { get; set; }
    }
}
