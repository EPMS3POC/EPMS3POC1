using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BundledServiceMasterProcedure
    {
        public long BundledServiceMasterProcedureId { get; set; }
        public long? BundledServiceId { get; set; }
        public long? MasterProcedureId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public BundledService BundledService { get; set; }
        public MasterProcedure MasterProcedure { get; set; }
    }
}
