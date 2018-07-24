using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            Appointment = new HashSet<Appointment>();
            AppointmentStatusLog = new HashSet<AppointmentStatusLog>();
        }

        public long AppointmentStatusId { get; set; }
        public string AppointmentStatusDescription { get; set; }
        public string AppointmentStatusCode { get; set; }
        public string AppointmentStatusName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<AppointmentStatusLog> AppointmentStatusLog { get; set; }
    }
}
