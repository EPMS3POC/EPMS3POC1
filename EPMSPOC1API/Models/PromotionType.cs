using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PromotionType
    {
        public PromotionType()
        {
            Promotion = new HashSet<Promotion>();
        }

        public long PromotionTypeId { get; set; }
        public string PromotionTypeDescription { get; set; }
        public string PromotionTypeCode { get; set; }
        public string PromotionTypeName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Promotion> Promotion { get; set; }
    }
}
