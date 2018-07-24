using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class InsurancePayerIdentity
    {
        public InsurancePayerIdentity()
        {
            Insurance = new HashSet<Insurance>();
        }

        public long ElectronicPayerIdentityId { get; set; }
        public long? InsurancePayerId { get; set; }
        public long? ClearingHouseId { get; set; }
        public string ElectronicPayerIdentity { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ClearingHouse ClearingHouse { get; set; }
        public InsurancePayer InsurancePayer { get; set; }
        public ICollection<Insurance> Insurance { get; set; }
    }
}
