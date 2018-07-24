using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class User
    {
        public User()
        {
            Person = new HashSet<Person>();
            RolePermission = new HashSet<RolePermission>();
            UserPermission = new HashSet<UserPermission>();
        }

        public long UserId { get; set; }
        public long FacilityId { get; set; }
        public long EntityId { get; set; }
        public long OrganizationId { get; set; }
        public long UserStatusId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public DateTime? LastAccessDateTime { get; set; }
        public long? UserTypeId { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ContractDate { get; set; }
        public long? UserSpecialtyId { get; set; }
        public string Answer { get; set; }
        public long? SecurityQuestionId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Entity Entity { get; set; }
        public Facility Facility { get; set; }
        public Organization Organization { get; set; }
        public SecurityQuestion SecurityQuestion { get; set; }
        public UserSpecialty UserSpecialty { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserType UserType { get; set; }
        public ICollection<Person> Person { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
