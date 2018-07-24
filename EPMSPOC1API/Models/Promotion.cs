using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            Coupon = new HashSet<Coupon>();
        }

        public long PromotionId { get; set; }
        public long MarketingId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DaysExtended { get; set; }
        public short? IsPatientLimited { get; set; }
        public short? IsRecordNotesExists { get; set; }
        public long? PromotionTypeId { get; set; }
        public string PromotionNotes { get; set; }
        public string PromotionDescription { get; set; }
        public string PromotionCode { get; set; }
        public string PromotionName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Marketing Marketing { get; set; }
        public PromotionType PromotionType { get; set; }
        public ICollection<Coupon> Coupon { get; set; }
    }
}
