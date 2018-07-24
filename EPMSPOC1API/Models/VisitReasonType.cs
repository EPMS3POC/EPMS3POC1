using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class VisitReasonType
    {
        public VisitReasonType()
        {
            MasterTreatmentPlan = new HashSet<MasterTreatmentPlan>();
            Prospect = new HashSet<Prospect>();
            Visit = new HashSet<Visit>();
        }

        public long VisitReasonTypeId { get; set; }
        public short? IsPriority { get; set; }
        public short? IsForceAllowed { get; set; }
        public string VisitReasonTypeDescription { get; set; }
        public string VisitReasonTypeCode { get; set; }
        public string VisitReasonTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<MasterTreatmentPlan> MasterTreatmentPlan { get; set; }
        public ICollection<Prospect> Prospect { get; set; }
        public ICollection<Visit> Visit { get; set; }
    }
}
