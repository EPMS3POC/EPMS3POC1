using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Insurance
    {
        public Insurance()
        {
            CoverageBook = new HashSet<CoverageBook>();
            Remittance = new HashSet<Remittance>();
        }

        public long InsuranceId { get; set; }
        public long SubscriberId { get; set; }
        public string InsuranceFacilityId { get; set; }
        public long? InsurancePayerId { get; set; }
        public long? InsurancePolicyTypeId { get; set; }
        public long? ElectronicPayerIdentityId { get; set; }
        public long? InsuranceStageTypeId { get; set; }
        public string GroupId { get; set; }
        public long? EmployerId { get; set; }
        public string InsuredId { get; set; }
        public string GroupName { get; set; }
        public string PlanName { get; set; }
        public long? EmploymentStatusId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? CoPay { get; set; }
        public decimal? Deductible { get; set; }
        public int? CoInsurance { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public InsurancePayerIdentity ElectronicPayerIdentity { get; set; }
        public InsurancePayer InsurancePayer { get; set; }
        public InsurancePolicyType InsurancePolicyType { get; set; }
        public InsuranceStageType InsuranceStageType { get; set; }
        public Subscriber Subscriber { get; set; }
        public ICollection<CoverageBook> CoverageBook { get; set; }
        public ICollection<Remittance> Remittance { get; set; }
    }
}
