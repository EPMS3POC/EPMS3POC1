using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AppointmentCancellationCode
    {
        public AppointmentCancellationCode()
        {
            AppointmentNoShowFee = new HashSet<AppointmentNoShowFee>();
        }

        public long AppointmentCancellationCodeId { get; set; }
        public short? IsNoShowCharge { get; set; }
        public decimal? DefaultCharge { get; set; }
        public string AppointmentCancellationCodeDescription { get; set; }
        public string AppointmentCancellationCodeCode { get; set; }
        public string AppointmentCancellationCodeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<AppointmentNoShowFee> AppointmentNoShowFee { get; set; }
    }
}
