using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CoverageProcedure
    {
        public long CoverageProcedureId { get; set; }
        public string Note { get; set; }
        public long? CoverageNetworkTypeId { get; set; }
        public int? IsCovered { get; set; }
        public long? ProcedureCodeCategoryId { get; set; }
        public long? CoverageBookId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CoverageBook CoverageBook { get; set; }
        public CoverageNetworkType CoverageNetworkType { get; set; }
        public ProcedureCodeCategory ProcedureCodeCategory { get; set; }
    }
}
