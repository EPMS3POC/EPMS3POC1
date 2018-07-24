using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class InsurancePolicyType
    {
        public InsurancePolicyType()
        {
            Insurance = new HashSet<Insurance>();
        }

        public long InsurancePolicyTypeId { get; set; }
        public string InsurancePolicyTypeDescription { get; set; }
        public string InsurancePolicyTypeCode { get; set; }
        public string InsurancePolicyTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Insurance> Insurance { get; set; }
    }
}
