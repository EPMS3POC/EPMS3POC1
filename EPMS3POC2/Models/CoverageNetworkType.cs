using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CoverageNetworkType
    {
        public CoverageNetworkType()
        {
            CoverageLimit = new HashSet<CoverageLimit>();
            CoverageProcedure = new HashSet<CoverageProcedure>();
        }

        public long CoverageNetworkTypeId { get; set; }
        public string CoverageNetworkTypeDescription { get; set; }
        public string CoverageNetworkTypeCode { get; set; }
        public string CoverageNetworkTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CoverageLimit> CoverageLimit { get; set; }
        public ICollection<CoverageProcedure> CoverageProcedure { get; set; }
    }
}
