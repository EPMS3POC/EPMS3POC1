using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Guarantor
    {
        public Guarantor()
        {
            Account = new HashSet<Account>();
        }

        public long GuarantorId { get; set; }
        public long PersonId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Person Person { get; set; }
        public ICollection<Account> Account { get; set; }
    }
}
