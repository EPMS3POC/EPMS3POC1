using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class InsuranceStageType
    {
        public InsuranceStageType()
        {
            Insurance = new HashSet<Insurance>();
        }

        public long InsuranceStageTypeId { get; set; }
        public string InsuranceStageTypeDescription { get; set; }
        public string InsuranceStageTypeCode { get; set; }
        public string InsuranceStageTypeName { get; set; }
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
