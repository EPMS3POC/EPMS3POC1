using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CouponAdjustment
    {
        public CouponAdjustment()
        {
            Coupon = new HashSet<Coupon>();
        }

        public long CouponAdjustmentId { get; set; }
        public string CouponAdjustmentDescription { get; set; }
        public string CouponAdjustmentCode { get; set; }
        public string CouponAdjustmentName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Coupon> Coupon { get; set; }
    }
}
