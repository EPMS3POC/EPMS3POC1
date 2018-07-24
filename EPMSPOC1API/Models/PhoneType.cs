using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            DiagnosticCenterPhone = new HashSet<DiagnosticCenterPhone>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public long PhoneTypeId { get; set; }
        public string PhoneTypeCode { get; set; }
        public string PhoneTypeName { get; set; }
        public string PhoneTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DiagnosticCenterPhone> DiagnosticCenterPhone { get; set; }
        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
