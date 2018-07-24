using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoverageLimitType
    {
        public CoverageLimitType()
        {
            CoverageLimit = new HashSet<CoverageLimit>();
        }

        public long CoverageLimitTypeId { get; set; }
        public string CoverageLimitTypeDescription { get; set; }
        public string CoverageLimitTypeCode { get; set; }
        public string CoverageLimitTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CoverageLimit> CoverageLimit { get; set; }
    }
}
