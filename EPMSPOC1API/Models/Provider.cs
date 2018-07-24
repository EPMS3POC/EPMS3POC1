using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Adjustment = new HashSet<Adjustment>();
            ExcuseNote = new HashSet<ExcuseNote>();
            PatientTreatmentPlan = new HashSet<PatientTreatmentPlan>();
            ProviderInsurance = new HashSet<ProviderInsurance>();
            Visit = new HashSet<Visit>();
        }

        public long ProviderId { get; set; }
        public long EmployeeId { get; set; }
        public string ProviderDoseSpotClinicianId { get; set; }
        public string Npinumber { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Employee Employee { get; set; }
        public ICollection<Adjustment> Adjustment { get; set; }
        public ICollection<ExcuseNote> ExcuseNote { get; set; }
        public ICollection<PatientTreatmentPlan> PatientTreatmentPlan { get; set; }
        public ICollection<ProviderInsurance> ProviderInsurance { get; set; }
        public ICollection<Visit> Visit { get; set; }
    }
}
