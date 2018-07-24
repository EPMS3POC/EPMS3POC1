using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Visit
    {
        public Visit()
        {
            Appointment = new HashSet<Appointment>();
            Claim = new HashSet<Claim>();
            Ledger = new HashSet<Ledger>();
            PatientProcedure = new HashSet<PatientProcedure>();
        }

        public long VisitId { get; set; }
        public int? VisitNumber { get; set; }
        public long? VisitReasonTypeId { get; set; }
        public short? IsWaitListed { get; set; }
        public long? ProviderId { get; set; }
        public DateTime? DateOfService { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? PatientTreatmentPlanId { get; set; }

        public PatientTreatmentPlan PatientTreatmentPlan { get; set; }
        public Provider Provider { get; set; }
        public VisitReasonType VisitReasonType { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Claim> Claim { get; set; }
        public ICollection<Ledger> Ledger { get; set; }
        public ICollection<PatientProcedure> PatientProcedure { get; set; }
    }
}
