using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPMS3POC1.Models
{
    public class PatientAccount
    {
        [Key]
        public long AccountId { get; set; }
        public decimal? AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SuffixName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Age { get; set; }
        public string GenderName { get; set; }
        public string RelationshipTypeName { get; set; }
        public string FacilityName { get; set; }
        public long? AccountGroup { get; set; }
        public string AccountStatusCode { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
    }
}
