using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DiagnosticCenterPhone
    {
        public long DiagnosticCenterPhoneId { get; set; }
        public long? PhoneId { get; set; }
        public long? DiagnosticCenterId { get; set; }
        public long? PhoneTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public DiagnosticCenter DiagnosticCenter { get; set; }
        public Phone Phone { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
