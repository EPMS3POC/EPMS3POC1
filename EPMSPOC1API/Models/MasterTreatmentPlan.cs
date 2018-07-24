using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MasterTreatmentPlan
    {
        public MasterTreatmentPlan()
        {
            MasterProcedure = new HashSet<MasterProcedure>();
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
        }

        public long MasterTreatmentPlanId { get; set; }
        public long? VisitReasonTypeId { get; set; }
        public string MasterTreatmentPlanCode { get; set; }
        public int? MasterTreatmentPlanNumber { get; set; }
        public string MasterTreatmentPlanDescription { get; set; }
        public long? AppointmentClassId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public AppointmentClass AppointmentClass { get; set; }
        public VisitReasonType VisitReasonType { get; set; }
        public ICollection<MasterProcedure> MasterProcedure { get; set; }
        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
    }
}
