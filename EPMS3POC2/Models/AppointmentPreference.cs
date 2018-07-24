using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class AppointmentPreference
    {
        public long AppointmentPreferenceId { get; set; }
        public long PatientId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Patient Patient { get; set; }
    }
}
