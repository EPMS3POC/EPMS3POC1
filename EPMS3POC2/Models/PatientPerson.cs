using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPMS3POC2.Models
{
    //[Table("PatientPerson", Schema = "dbo")]
    public class PatientPerson
    {
        [Key]
        [Display(Name = "Id")]
        public long PersonId { get; set; }
        [Display(Name = "FName")]
        public string FirstName { get; set; }
        [Display(Name = "LName")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Gender")]
        public string GenderName { get; set; }
        [Display(Name = "SSN")]
        public string SocialSecurityNumber { get; set; }
        [Display(Name = "Relationship")]
        public string RelationshipTypeName { get; set; }
        public string FacilityName { get; set; }

        [Display(Name = "Appointment")]
        [DataType(DataType.Date)]
        public DateTime? AppointmentDate { get; set; }
        [Display(Name = "Status")]
        public int RecordStatus { get; set; }
    }
}
