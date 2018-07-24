using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CoverageLimit
    {
        public long CoverageLimitId { get; set; }
        public decimal? LimitAmount { get; set; }
        public decimal? UsedAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
        public long? CoverageNetworkTypeId { get; set; }
        public long? CoveragePlanTypeId { get; set; }
        public long? CoverageLimitTypeId { get; set; }
        public long? CoverageBookId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CoverageBook CoverageBook { get; set; }
        public CoverageLimitType CoverageLimitType { get; set; }
        public CoverageNetworkType CoverageNetworkType { get; set; }
        public CoveragePlanType CoveragePlanType { get; set; }
    }
}
