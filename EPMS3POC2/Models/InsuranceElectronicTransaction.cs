﻿using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class InsuranceElectronicTransaction
    {
        public long InsuranceElectronicTransactionId { get; set; }
        public short? IsSupported { get; set; }
        public long? InsuranceElectronicTransactionTypeId { get; set; }
        public long? InsurancePayerId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public InsuranceElectronicTransactionType InsuranceElectronicTransactionType { get; set; }
        public InsurancePayer InsurancePayer { get; set; }
    }
}
