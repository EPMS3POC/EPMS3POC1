using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class InsurancePayer
    {
        public InsurancePayer()
        {
            CoverageBook = new HashSet<CoverageBook>();
            Insurance = new HashSet<Insurance>();
            InsuranceAddress = new HashSet<InsuranceAddress>();
            InsuranceContact = new HashSet<InsuranceContact>();
            InsuranceElectronicTransaction = new HashSet<InsuranceElectronicTransaction>();
            InsurancePayerIdentity = new HashSet<InsurancePayerIdentity>();
            ProviderInsurance = new HashSet<ProviderInsurance>();
        }

        public long InsurancePayerId { get; set; }
        public string CompanyNumber { get; set; }
        public string InsurancePayerName { get; set; }
        public string InsuranceCompanyName { get; set; }
        public short? AllowElectronicClaim { get; set; }
        public string InsurancePayerCode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int? InsurancePayerTypeFk { get; set; }
        public int? MedicaidClaimTypeFk { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<CoverageBook> CoverageBook { get; set; }
        public ICollection<Insurance> Insurance { get; set; }
        public ICollection<InsuranceAddress> InsuranceAddress { get; set; }
        public ICollection<InsuranceContact> InsuranceContact { get; set; }
        public ICollection<InsuranceElectronicTransaction> InsuranceElectronicTransaction { get; set; }
        public ICollection<InsurancePayerIdentity> InsurancePayerIdentity { get; set; }
        public ICollection<ProviderInsurance> ProviderInsurance { get; set; }
    }
}
