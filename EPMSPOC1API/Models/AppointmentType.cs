using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            Appointment = new HashSet<Appointment>();
        }

        public long AppointmentTypeId { get; set; }
        public string Cptcode { get; set; }
        public int? TimeslotDurationInMinutes { get; set; }
        public string AppointmentTypeDescription { get; set; }
        public string AppointmentTypeCode { get; set; }
        public string AppointmentTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
    }
}
