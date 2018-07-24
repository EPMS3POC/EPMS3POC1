using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientTreatmentPlan
    {
        public PatientTreatmentPlan()
        {
            PatientProcedure = new HashSet<PatientProcedure>();
            Visit = new HashSet<Visit>();
        }

        public long PatientTreatmentPlanId { get; set; }
        public long PatientId { get; set; }
        public long TreatmentPlanOptionId { get; set; }
        public long? PatientToothId { get; set; }
        public long? BundledServiceId { get; set; }
        public long? MasterTreatmentPlanId { get; set; }
        public long? ProviderId { get; set; }
        public string ToothSurface { get; set; }
        public string TotalPlanFee { get; set; }
        public decimal? TotalCouponDiscount { get; set; }
        public decimal? TotalEstimatedInsuranceDiscount { get; set; }
        public decimal? TotalEstimatedInsuranceBenefit { get; set; }
        public decimal? PatientFinancialResponsibility { get; set; }
        public decimal? PatientBalance { get; set; }
        public decimal? PlannedPayment { get; set; }
        public decimal? RemainingAmount { get; set; }
        public string PdfFileName { get; set; }
        public string PdfFilePath { get; set; }
        public DateTime? EstimateRunDateTime { get; set; }
        public DateTime? TreatmentPlanDate { get; set; }
        public string DiagnosingProvider { get; set; }
        public string InsideReferringProvider { get; set; }
        public short? IsOverrideFeeSchedule { get; set; }
        public short? IsContractRequired { get; set; }
        public string ContractNumber { get; set; }
        public string ExceptionNumber { get; set; }
        public short? IsPreAuthorizationRequired { get; set; }
        public string PreAuthorizationNumber { get; set; }
        public DateTime? DatePreAuthorizationFiled { get; set; }
        public DateTime? PreAuthorizationExpires { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateComplete { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public BundledService BundledService { get; set; }
        public MasterTreatmentPlan MasterTreatmentPlan { get; set; }
        public Patient Patient { get; set; }
        public PatientTooth PatientTooth { get; set; }
        public Provider Provider { get; set; }
        public TreatmentPlanOption TreatmentPlanOption { get; set; }
        public ICollection<PatientProcedure> PatientProcedure { get; set; }
        public ICollection<Visit> Visit { get; set; }
    }
}
