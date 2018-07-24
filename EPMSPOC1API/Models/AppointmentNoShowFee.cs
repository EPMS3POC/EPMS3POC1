using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentNoShowFee
    {
        public int AppointmentNoShowFeeId { get; set; }
        public decimal? DefaultCharge { get; set; }
        public long? AppointmentCancellationCodeId { get; set; }
        public long? AppointmentId { get; set; }
        public string InitiatedByWhom { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Appointment Appointment { get; set; }
        public AppointmentCancellationCode AppointmentCancellationCode { get; set; }
    }
}
