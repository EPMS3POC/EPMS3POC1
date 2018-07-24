using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DemographicField
    {
        public DemographicField()
        {
            DemographicRule = new HashSet<DemographicRule>();
        }

        public long DemographicFieldId { get; set; }
        public string DemographicFieldDescription { get; set; }
        public string DemographicFieldCode { get; set; }
        public string DemographicFieldName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DemographicRule> DemographicRule { get; set; }
    }
}
