using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            Adjustment = new HashSet<Adjustment>();
            TransactionCredit = new HashSet<TransactionCredit>();
            TransactionDebit = new HashSet<TransactionDebit>();
        }

        public long TransactionId { get; set; }
        public long LedgerId { get; set; }
        public decimal? WriteOffAmount { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Ledger Ledger { get; set; }
        public ICollection<Adjustment> Adjustment { get; set; }
        public ICollection<TransactionCredit> TransactionCredit { get; set; }
        public ICollection<TransactionDebit> TransactionDebit { get; set; }
    }
}
