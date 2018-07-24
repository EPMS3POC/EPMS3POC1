using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Account
    {
        public Account()
        {
            CollectionAccount = new HashSet<CollectionAccount>();
            CreditAccount = new HashSet<CreditAccount>();
            Ledger = new HashSet<Ledger>();
            Patient = new HashSet<Patient>();
        }

        public long AccountId { get; set; }
        public long FacilityId { get; set; }
        public decimal? AccountNumber { get; set; }
        public long? AccountGroup { get; set; }
        public long? GuarantorId { get; set; }
        public long? SubscriberId { get; set; }
        public long? StatementId { get; set; }
        public long? AccountStatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public AccountStatus AccountStatus { get; set; }
        public Facility Facility { get; set; }
        public Guarantor Guarantor { get; set; }
        public Statement Statement { get; set; }
        public Subscriber Subscriber { get; set; }
        public ICollection<CollectionAccount> CollectionAccount { get; set; }
        public ICollection<CreditAccount> CreditAccount { get; set; }
        public ICollection<Ledger> Ledger { get; set; }
        public ICollection<Patient> Patient { get; set; }
    }
}
