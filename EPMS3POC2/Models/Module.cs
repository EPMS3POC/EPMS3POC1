using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Module
    {
        public Module()
        {
            RolePermission = new HashSet<RolePermission>();
            UserPermission = new HashSet<UserPermission>();
            View = new HashSet<View>();
        }

        public long ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<RolePermission> RolePermission { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
        public ICollection<View> View { get; set; }
    }
}
