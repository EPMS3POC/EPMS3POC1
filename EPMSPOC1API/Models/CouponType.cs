using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CouponType
    {
        public CouponType()
        {
            Coupon = new HashSet<Coupon>();
        }

        public long CouponTypeId { get; set; }
        public string CouponTypeDescription { get; set; }
        public string CouponTypeCode { get; set; }
        public string CouponTypeName { get; set; }
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
