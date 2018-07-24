using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Ledger
    {
        public Ledger()
        {
            Transaction = new HashSet<Transaction>();
        }

        public long LedgerId { get; set; }
        public long AccountId { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public decimal? BalanceDue { get; set; }
        public long? VisitId { get; set; }
        public decimal? BilledAmount { get; set; }
        public decimal? AllowedAmount { get; set; }
        public decimal? DeductableAmount { get; set; }
        public decimal? CoInsurance { get; set; }
        public decimal? CoPay { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public decimal? LedgerBalance { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Account Account { get; set; }
        public Visit Visit { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
