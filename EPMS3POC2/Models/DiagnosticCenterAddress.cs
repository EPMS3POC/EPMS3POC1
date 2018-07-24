using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DiagnosticCenterAddress
    {
        public long DiagnosticCenterAddressId { get; set; }
        public long? AddressId { get; set; }
        public long? DiagnosticCenterId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Address Address { get; set; }
        public DiagnosticCenter DiagnosticCenter { get; set; }
    }
}
