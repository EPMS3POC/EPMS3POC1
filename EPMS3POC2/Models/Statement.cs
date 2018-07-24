using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Statement
    {
        public Statement()
        {
            Account = new HashSet<Account>();
        }

        public long StatementId { get; set; }
        public long AccountingId { get; set; }
        public string StatementName { get; set; }
        public string StatementDescription { get; set; }
        public string StatementCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Accounting Accounting { get; set; }
        public ICollection<Account> Account { get; set; }
    }
}
