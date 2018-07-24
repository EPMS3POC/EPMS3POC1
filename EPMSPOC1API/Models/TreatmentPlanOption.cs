using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class TreatmentPlanOption
    {
        public TreatmentPlanOption()
        {
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
        }

        public long TreatmentPlanOptionId { get; set; }
        public string TreatmentPlanOptionCode { get; set; }
        public string TreatmentPlanOptionName { get; set; }
        public string TreatmentPlanOptionDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
    }
}
