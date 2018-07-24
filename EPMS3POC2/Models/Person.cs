using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Person
    {
        public Person()
        {
            DiagnosticCenterContact = new HashSet<DiagnosticCenterContact>();
            GeneralContractorContact = new HashSet<GeneralContractorContact>();
            Guarantor = new HashSet<Guarantor>();
            InsuranceContact = new HashSet<InsuranceContact>();
            PersonAddress = new HashSet<PersonAddress>();
            PersonLanguage = new HashSet<PersonLanguage>();
            PersonPhone = new HashSet<PersonPhone>();
            Relationship = new HashSet<Relationship>();
            Subscriber = new HashSet<Subscriber>();
        }

        public long PersonId { get; set; }
        public long? UserId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? PrefixId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long? IdentityProofTypeId { get; set; }
        public string IdentityProofNumber { get; set; }
        public DateTime? IdentityExpiryDate { get; set; }
        public long? SuffixId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? GenderId { get; set; }
        public Gender Gender { get; set; }
        public IdentityProofType IdentityProofType { get; set; }
        public Prefix Prefix { get; set; }
        public Suffix Suffix { get; set; }
        public User User { get; set; }
        public ICollection<DiagnosticCenterContact> DiagnosticCenterContact { get; set; }
        public ICollection<GeneralContractorContact> GeneralContractorContact { get; set; }
        public ICollection<Guarantor> Guarantor { get; set; }
        public ICollection<InsuranceContact> InsuranceContact { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
        public ICollection<PersonLanguage> PersonLanguage { get; set; }
        public ICollection<PersonPhone> PersonPhone { get; set; }
        public ICollection<Relationship> Relationship { get; set; }
        public ICollection<Subscriber> Subscriber { get; set; }
    }
}
