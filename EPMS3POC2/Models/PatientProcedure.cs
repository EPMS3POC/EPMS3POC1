using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PatientProcedure
    {
        public PatientProcedure()
        {
            PatientNote = new HashSet<PatientNote>();
            PatientProcedureLog = new HashSet<PatientProcedureLog>();
            TransactionDebit = new HashSet<TransactionDebit>();
        }

        public long PatientProcedureId { get; set; }
        public long? CategoryFilterId { get; set; }
        public long? VisitId { get; set; }
        public int? Tooth { get; set; }
        public string Surface { get; set; }
        public decimal? Fee { get; set; }
        public decimal? CouponDiscount { get; set; }
        public decimal? EstimatedInsuranceDiscount { get; set; }
        public decimal? EstimatedInsuranceBenefit { get; set; }
        public decimal? PatientFinancialResposibility { get; set; }
        public string ToothQuadrantCode { get; set; }
        public string SurfaceCode { get; set; }
        public short? IsFeeManual { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? MasterProcedureId { get; set; }
        public bool? IsProcedureApprovalRequired { get; set; }
        public bool? IsProcedureApproved { get; set; }
        public int? ProcedureStatus { get; set; }
        public long? PatientToothId { get; set; }
        public long? PatientTreatmentPlanId { get; set; }

        public CategoryFilter CategoryFilter { get; set; }
        public MasterProcedure MasterProcedure { get; set; }
        public PatientTooth PatientTooth { get; set; }
        public PatientTreatmentPlan PatientTreatmentPlan { get; set; }
        public Visit Visit { get; set; }
        public ICollection<PatientNote> PatientNote { get; set; }
        public ICollection<PatientProcedureLog> PatientProcedureLog { get; set; }
        public ICollection<TransactionDebit> TransactionDebit { get; set; }
    }
}
