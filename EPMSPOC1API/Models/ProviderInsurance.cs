using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ProviderInsurance
    {
        public ProviderInsurance()
        {
            Claim = new HashSet<Claim>();
        }

        public long ProviderInsuranceId { get; set; }
        public long? ProviderId { get; set; }
        public string LicenseNumber { get; set; }
        public long? ProviderSpecialtyCodeId { get; set; }
        public long? InsurancePayerId { get; set; }
        public string PayeeIdentification { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public InsurancePayer InsurancePayer { get; set; }
        public Provider Provider { get; set; }
        public ICollection<Claim> Claim { get; set; }
    }
}
