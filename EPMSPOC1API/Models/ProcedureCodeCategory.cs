using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ProcedureCodeCategory
    {
        public ProcedureCodeCategory()
        {
            CoverageProcedure = new HashSet<CoverageProcedure>();
        }

        public long ProcedureCodeCategoryId { get; set; }
        public string ProcedureCodeCategory1 { get; set; }
        public string ProcedureCodeMin { get; set; }
        public string ProcedureCodeMax { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CoverageProcedure> CoverageProcedure { get; set; }
    }
}
