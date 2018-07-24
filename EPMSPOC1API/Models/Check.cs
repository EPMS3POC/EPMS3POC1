using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Check
    {
        public Check()
        {
            TransactionCredit = new HashSet<TransactionCredit>();
        }

        public long CheckId { get; set; }
        public string CheckNumber { get; set; }
        public string DateOfPayment { get; set; }
        public string Micrdata { get; set; }
        public string AccountNumber { get; set; }
        public string BankRountingNumber { get; set; }
        public string Amount { get; set; }
        public string CheckImage { get; set; }
        public string IclreceivedDate { get; set; }
        public long? MasterPayerId { get; set; }
        public long? MasterPayeeId { get; set; }
        public string CheckFilieName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public MasterPayee MasterPayee { get; set; }
        public MasterPayer MasterPayer { get; set; }
        public ICollection<TransactionCredit> TransactionCredit { get; set; }
    }
}
