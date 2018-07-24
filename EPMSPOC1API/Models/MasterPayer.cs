using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MasterPayer
    {
        public MasterPayer()
        {
            Check = new HashSet<Check>();
        }

        public long MasterPayerId { get; set; }
        public string PayerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Check> Check { get; set; }
    }
}
