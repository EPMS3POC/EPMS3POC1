using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DiagnosticCenter
    {
        public DiagnosticCenter()
        {
            DiagnosticCenterAddress = new HashSet<DiagnosticCenterAddress>();
            DiagnosticCenterContact = new HashSet<DiagnosticCenterContact>();
            DiagnosticCenterPhone = new HashSet<DiagnosticCenterPhone>();
            OrderImage = new HashSet<OrderImage>();
        }

        public long DiagnosticCenterId { get; set; }
        public string DiagnosticCenterName { get; set; }
        public long? FacilityId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<DiagnosticCenterAddress> DiagnosticCenterAddress { get; set; }
        public ICollection<DiagnosticCenterContact> DiagnosticCenterContact { get; set; }
        public ICollection<DiagnosticCenterPhone> DiagnosticCenterPhone { get; set; }
        public ICollection<OrderImage> OrderImage { get; set; }
    }
}
