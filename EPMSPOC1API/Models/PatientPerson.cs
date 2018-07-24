using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPMS3POC1.Models
{
    //[Table("PatientPerson", Schema = "dbo")]
    public class PatientPerson
    {
            [Key]
            public long PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime? BirthDate { get; set; }
            public string GenderName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string RelationshipTypeName { get; set; }
            public string FacilityName { get; set; }
            public DateTime? AppointmentDate { get; set; }
            public int RecordStatus { get; set; }
        }
    }
