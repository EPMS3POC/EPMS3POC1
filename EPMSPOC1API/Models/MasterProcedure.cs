using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class MasterProcedure
    {
        public MasterProcedure()
        {
            BundledServiceMasterProcedure = new HashSet<BundledServiceMasterProcedure>();
            Coupon = new HashSet<Coupon>();
            FeeScheduleDetail = new HashSet<FeeScheduleDetail>();
            PatientProcedure = new HashSet<PatientProcedure>();
        }

        public long MasterProcedureId { get; set; }
        public long? MasterTreatmentPlanId { get; set; }
        public string Cdtcode { get; set; }
        public string SnodentCode { get; set; }
        public string Icd10code { get; set; }
        public string MasterProcedureDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public MasterTreatmentPlan MasterTreatmentPlan { get; set; }
        public ICollection<BundledServiceMasterProcedure> BundledServiceMasterProcedure { get; set; }
        public ICollection<Coupon> Coupon { get; set; }
        public ICollection<FeeScheduleDetail> FeeScheduleDetail { get; set; }
        public ICollection<PatientProcedure> PatientProcedure { get; set; }
    }
}
