using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ExcuseNote
    {
        public long ExcuseNoteId { get; set; }
        public long? ProviderId { get; set; }
        public DateTime? ExcuseDateTime { get; set; }
        public DateTime? AppointmentStartTime { get; set; }
        public DateTime? AppointmentEndTime { get; set; }
        public bool? ExcuseInHours { get; set; }
        public bool? ExcuseInDays { get; set; }
        public int? NumberOfHoursOrDays { get; set; }
        public DateTime? ReturnDate { get; set; }
        public long? AppointmentId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Appointment Appointment { get; set; }
        public Provider Provider { get; set; }
    }
}
