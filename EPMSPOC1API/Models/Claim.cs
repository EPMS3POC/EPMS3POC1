using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Claim
    {
        public long ClaimId { get; set; }
        public string ClaimNumber { get; set; }
        public string Npinumber { get; set; }
        public string GroupNumber { get; set; }
        public string PlanCode { get; set; }
        public string ServiceTypeCode { get; set; }
        public DateTime? CardIssueDate { get; set; }
        public DateTime? GeneratedDate { get; set; }
        public long? ClaimTypeId { get; set; }
        public long? ProviderInsuranceId { get; set; }
        public long? VisitId { get; set; }
        public long? ClaimStatusId { get; set; }
        public decimal? StandardCharges { get; set; }
        public decimal? TreatmentPlanCharges { get; set; }
        public decimal? BalanceAmount { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ClaimStatus ClaimStatus { get; set; }
        public ClaimType ClaimType { get; set; }
        public ProviderInsurance ProviderInsurance { get; set; }
        public Visit Visit { get; set; }
    }
}
