using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentClass
    {
        public AppointmentClass()
        {
            MasterTreatmentPlan = new HashSet<MasterTreatmentPlan>();
        }

        public long AppointmentClassId { get; set; }
        public long? ProviderTypeId { get; set; }
        public long? OperatoryId { get; set; }
        public string AppointmentClassDescription { get; set; }
        public string AppointmentClassCode { get; set; }
        public string AppointmentClassName { get; set; }
        public short? IsExamDoctorRequired { get; set; }
        public int? ShortestAppointmentOpeningToSave { get; set; }
        public int? LongestAppointmentOpeningToSave { get; set; }
        public int? MinutesPerAppointmentUnit { get; set; }
        public int? DaysToHoldSchedule { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Operatory Operatory { get; set; }
        public ProviderType ProviderType { get; set; }
        public ICollection<MasterTreatmentPlan> MasterTreatmentPlan { get; set; }
    }
}
