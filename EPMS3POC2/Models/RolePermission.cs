using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class RolePermission
    {
        public long RolePermissionId { get; set; }
        public long UserId { get; set; }
        public string RolePermissionCode { get; set; }
        public string RolePermissionName { get; set; }
        public string RolePermissionDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ModuleId { get; set; }
        public long? FieldId { get; set; }
        public long? ViewId { get; set; }
        public long? RoleId { get; set; }
        public long? PermissionId { get; set; }

        public Field Field { get; set; }
        public Module Module { get; set; }
        public Permission Permission { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
        public View View { get; set; }
    }
}
