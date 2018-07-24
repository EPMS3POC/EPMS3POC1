using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ClaimStatus
    {
        public ClaimStatus()
        {
            Claim = new HashSet<Claim>();
        }

        public long ClaimStatusId { get; set; }
        public string ClaimStatusDescription { get; set; }
        public string ClaimStatusCode { get; set; }
        public string ClaimStatusName { get; set; }
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
