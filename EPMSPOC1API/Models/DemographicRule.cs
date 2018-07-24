using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class DemographicRule
    {
        public long DemographicRuleId { get; set; }
        public long? RuleConditionId { get; set; }
        public long? RuleOperatorId { get; set; }
        public long? CouponId { get; set; }
        public long? DemographicFieldId { get; set; }
        public string RuleValueCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Coupon Coupon { get; set; }
        public DemographicField DemographicField { get; set; }
        public RuleCondition RuleCondition { get; set; }
        public RuleOperator RuleOperator { get; set; }
    }
}
