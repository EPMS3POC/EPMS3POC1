﻿using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class UserPermission
    {
        public long UserPermissionId { get; set; }
        public long UserId { get; set; }
        public string UserPermissionCode { get; set; }
        public string UserPermissionName { get; set; }
        public string UserPermissionDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ModuleId { get; set; }
        public long? PermissionId { get; set; }
        public long? ViewId { get; set; }
        public long? FieldId { get; set; }

        public Field Field { get; set; }
        public Module Module { get; set; }
        public Permission Permission { get; set; }
        public User User { get; set; }
        public View View { get; set; }
    }
}
