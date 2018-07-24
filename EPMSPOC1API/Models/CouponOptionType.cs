using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CouponOptionType
    {
        public CouponOptionType()
        {
            CouponOption = new HashSet<CouponOption>();
        }

        public long CouponOptionTypeId { get; set; }
        public string CouponOptionTypeDescription { get; set; }
        public string CouponOptionTypeCode { get; set; }
        public string CouponOptionTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CouponOption> CouponOption { get; set; }
    }
}
