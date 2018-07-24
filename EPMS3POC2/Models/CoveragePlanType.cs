using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoveragePlanType
    {
        public CoveragePlanType()
        {
            CoverageLimit = new HashSet<CoverageLimit>();
        }

        public long CoveragePlanTypeId { get; set; }
        public string CoveragePlanTypeDescription { get; set; }
        public string CoveragePlanTypeCode { get; set; }
        public string CoveragePlanTypeName { get; set; }
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
