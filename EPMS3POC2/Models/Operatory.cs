using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Operatory
    {
        public Operatory()
        {
            AppointmentClass = new HashSet<AppointmentClass>();
            TimeSlot = new HashSet<TimeSlot>();
        }

        public long OperatoryId { get; set; }
        public long FacilityScheduleId { get; set; }
        public short? IsReadOnly { get; set; }
        public int? Priority { get; set; }
        public string OperatoryDescription { get; set; }
        public string OperatoryCode { get; set; }
        public string OperatoryName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public FacilitySchedule FacilitySchedule { get; set; }
        public ICollection<AppointmentClass> AppointmentClass { get; set; }
        public ICollection<TimeSlot> TimeSlot { get; set; }
    }
}
