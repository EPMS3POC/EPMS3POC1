using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AppointmentTimeSlot = new HashSet<AppointmentTimeSlot>();
            ConsentForm = new HashSet<ConsentForm>();
            DocumentMapping = new HashSet<DocumentMapping>();
            PatientConsentForm = new HashSet<PatientConsentForm>();
            PerioExam = new HashSet<PerioExam>();
            Provider = new HashSet<Provider>();
            VitalState = new HashSet<VitalState>();
        }

        public long EmployeeId { get; set; }
        public long UserId { get; set; }
        public long? FacilityScheduleId { get; set; }
        public long? ProviderTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? EmployeeTypeId { get; set; }
        public long? FacilityId { get; set; }

        public EmployeeType EmployeeType { get; set; }
        public Facility Facility { get; set; }
        public FacilitySchedule FacilitySchedule { get; set; }
        public ProviderType ProviderType { get; set; }
        public ICollection<AppointmentTimeSlot> AppointmentTimeSlot { get; set; }
        public ICollection<ConsentForm> ConsentForm { get; set; }
        public ICollection<DocumentMapping> DocumentMapping { get; set; }
        public ICollection<PatientConsentForm> PatientConsentForm { get; set; }
        public ICollection<PerioExam> PerioExam { get; set; }
        public ICollection<Provider> Provider { get; set; }
        public ICollection<VitalState> VitalState { get; set; }
    }
}
