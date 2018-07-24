using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CouponOption
    {
        public long CouponOptionId { get; set; }
        public string CouponOptionlValue { get; set; }
        public long? CouponOptionTypeId { get; set; }
        public long? CouponId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Coupon Coupon { get; set; }
        public CouponOptionType CouponOptionType { get; set; }
    }
}
