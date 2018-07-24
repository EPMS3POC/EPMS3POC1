using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class RuleCondition
    {
        public RuleCondition()
        {
            DemographicRule = new HashSet<DemographicRule>();
        }

        public long RuleConditionId { get; set; }
        public string RuleConditionDescription { get; set; }
        public string RuleConditionCode { get; set; }
        public string RuleConditionName { get; set; }
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
