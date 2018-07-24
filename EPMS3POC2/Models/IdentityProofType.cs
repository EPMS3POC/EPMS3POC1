using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class IdentityProofType
    {
        public IdentityProofType()
        {
            Person = new HashSet<Person>();
        }

        public long IdentityProofTypeId { get; set; }
        public string IdentityProofTypeCode { get; set; }
        public string IdentityProofTypeName { get; set; }
        public string IdentityProofTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}
