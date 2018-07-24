using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class AccountStatus
    {
        public AccountStatus()
        {
            Account = new HashSet<Account>();
        }

        public long AccountStatusId { get; set; }
        public string AccountStatusCode { get; set; }
        public string AccountStatusName { get; set; }
        public string AccountStatusDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
