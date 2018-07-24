using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class InsuranceElectronicTransactionType
    {
        public InsuranceElectronicTransactionType()
        {
            InsuranceElectronicTransaction = new HashSet<InsuranceElectronicTransaction>();
        }

        public long InsuranceElectronicTransactionTypeId { get; set; }
        public string InsuranceElectronicTransactionTypeDescription { get; set; }
        public string InsuranceElectronicTransactionTypeCode { get; set; }
        public string InsuranceElectronicTransactionTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<InsuranceElectronicTransaction> InsuranceElectronicTransaction { get; set; }
    }
}
