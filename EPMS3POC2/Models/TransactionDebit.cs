using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class TransactionDebit
    {
        public long TransactionDebitId { get; set; }
        public long TransactionId { get; set; }
        public long? PatientProcedureId { get; set; }
        public long? PatientProcedureLogId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public PatientProcedure PatientProcedure { get; set; }
        public PatientProcedureLog PatientProcedureLog { get; set; }
        public Transaction Transaction { get; set; }
    }
}
