using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class CreditAccountStatus
    {
        public CreditAccountStatus()
        {
            CreditAccount = new HashSet<CreditAccount>();
        }

        public long CreditAccountStatusId { get; set; }
        public string CreditAccountStatusName { get; set; }
        public string CreditAccountStatusDescription { get; set; }
        public string CreditAccountStatusCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CreditAccount> CreditAccount { get; set; }
    }
}
