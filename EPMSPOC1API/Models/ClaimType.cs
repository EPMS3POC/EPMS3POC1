using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ClaimType
    {
        public ClaimType()
        {
            Claim = new HashSet<Claim>();
        }

        public long ClaimTypeId { get; set; }
        public string ClaimTypeDescription { get; set; }
        public string ClaimTypeCode { get; set; }
        public string ClaimTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Claim> Claim { get; set; }
    }
}
