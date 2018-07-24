using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentTimeSlot
    {
        public long AppointmentTimeSlotId { get; set; }
        public long TimeSlotId { get; set; }
        public long AppointmentId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? EmployeeId { get; set; }

        public Appointment Appointment { get; set; }
        public Employee Employee { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}
