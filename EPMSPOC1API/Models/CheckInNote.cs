using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CheckInNote
    {
        public long CheckInNoteId { get; set; }
        public string CheckInNote1 { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
