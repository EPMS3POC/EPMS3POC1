using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class ChartAuditStatus
    {
        public ChartAuditStatus()
        {
            ChartAudit = new HashSet<ChartAudit>();
        }

        public long ChartAuditStatusId { get; set; }
        public string ChartAuditStatusDescription { get; set; }
        public string ChartAuditStatusCode { get; set; }
        public string ChartAuditStatusName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<ChartAudit> ChartAudit { get; set; }
    }
}
