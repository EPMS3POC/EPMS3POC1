using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentStatusLog
    {
        public long AppointmentStatusLogId { get; set; }
        public long AppointmentId { get; set; }
        public DateTime? LogDateTime { get; set; }
        public long? PreviousStatusId { get; set; }
        public long? AppointmentStatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Appointment Appointment { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
