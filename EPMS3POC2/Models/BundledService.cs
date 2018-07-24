using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class BundledService
    {
        public BundledService()
        {
            BundledServiceMasterProcedure = new HashSet<BundledServiceMasterProcedure>();
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
        }

        public long BundledServiceId { get; set; }
        public string BundledServiceCode { get; set; }
        public string BundledServiceName { get; set; }
        public string BundledServiceDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<BundledServiceMasterProcedure> BundledServiceMasterProcedure { get; set; }
        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
    }
}
