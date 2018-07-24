using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponOption = new HashSet<CouponOption>();
            DemographicRule = new HashSet<DemographicRule>();
        }

        public long CouponId { get; set; }
        public long CouponTypeId { get; set; }
        public string CouponTitle { get; set; }
        public string AdjustmentValue { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public long? CouponAdjustmentId { get; set; }
        public long? MasterProcedureId { get; set; }
        public string CouponDescription { get; set; }
        public string CouponCode { get; set; }
        public long? PromotionId { get; set; }
        public long? CouponStatusId { get; set; }
        public short? IsSendToPortal { get; set; }
        public short? IsSuperCoupon { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CouponAdjustment CouponAdjustment { get; set; }
        public CouponStatus CouponStatus { get; set; }
        public CouponType CouponType { get; set; }
        public MasterProcedure MasterProcedure { get; set; }
        public Promotion Promotion { get; set; }
        public ICollection<CouponOption> CouponOption { get; set; }
        public ICollection<DemographicRule> DemographicRule { get; set; }
    }
}
