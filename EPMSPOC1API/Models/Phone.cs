using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Phone
    {
        public Phone()
        {
            DiagnosticCenterPhone = new HashSet<DiagnosticCenterPhone>();
            EntityPhone = new HashSet<EntityPhone>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public long PhoneId { get; set; }
        public string Extension { get; set; }
        public string IsTextCapable { get; set; }
        public string AreaCode { get; set; }
        public string Nxx { get; set; }
        public string Line { get; set; }
        public string CountryCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DiagnosticCenterPhone> DiagnosticCenterPhone { get; set; }
        public ICollection<EntityPhone> EntityPhone { get; set; }
        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
