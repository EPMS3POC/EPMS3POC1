using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class FeeSchedule
    {
        public FeeSchedule()
        {
            FeeScheduleDetail = new HashSet<FeeScheduleDetail>();
        }

        public long FeeScheduleId { get; set; }
        public long? FeeScheduleTypeId { get; set; }
        public short? IsSpecialtyFee { get; set; }
        public short? IsBasedOnFee { get; set; }
        public short? IsAdultFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string FeeScheduleDescription { get; set; }
        public string FeeScheduleCode { get; set; }
        public string FeeScheduleName { get; set; }
        public long? InsurancePayerId { get; set; }
        public long? ProviderInsuranceId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public FeeScheduleType FeeScheduleType { get; set; }
        public ICollection<FeeScheduleDetail> FeeScheduleDetail { get; set; }
    }
}
