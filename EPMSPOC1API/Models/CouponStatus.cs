using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CouponStatus
    {
        public CouponStatus()
        {
            Coupon = new HashSet<Coupon>();
        }

        public long CouponStatusId { get; set; }
        public string CouponStatusDescription { get; set; }
        public string CouponStatusCode { get; set; }
        public string CouponStatusName { get; set; }
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
