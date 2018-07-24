using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class RuleOperator
    {
        public RuleOperator()
        {
            DemographicRule = new HashSet<DemographicRule>();
        }

        public long RuleOperatorId { get; set; }
        public string RuleOperatorDescription { get; set; }
        public string RuleOperatorCode { get; set; }
        public string RuleOperatorName { get; set; }
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
