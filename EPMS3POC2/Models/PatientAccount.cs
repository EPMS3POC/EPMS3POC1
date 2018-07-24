using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPMS3POC2.Models
{
    //[Table("PatientPerson"{ get; set; }Schema = "dbo")]
    public class PatientAccount
    {
        [Key]
        [Display(Name = "Id")]
        public long AccountId { get; set; }
        [Display(Name = "Account#")]
        public decimal? AccountNumber { get; set; }

        [Display(Name = "FName")]
        public string FirstName { get; set; }
        [Display(Name = "MName")]
        public string MiddleName { get; set; }
        [Display(Name = "LName")]
        public string LastName { get; set; }

        [Display(Name = "Suffix")]
        public string SuffixName { get; set; }

        [Display(Name = "SSN")]
        public string SocialSecurityNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        public DateTime? BirthDate { get; set; }
        public long Age { get; set; }

        [Display(Name = "Gender")]
        public string GenderName { get; set; }

        [Display(Name ="Relationship")]
        public string RelationshipTypeName { get; set; }
        public string Facility { get; set; }

        [Display(Name = "Group")]
        public long? AccountGroup { get; set; }

        [Display(Name = "Status")]
        public int RecordStatus { get; set; }

        [Display(Name = "Phone")]
        public string HomePhone { get; set; }
        public string Email { get; set; }

    }
}
