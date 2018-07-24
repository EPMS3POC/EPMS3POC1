using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class View
    {
        public View()
        {
            Field = new HashSet<Field>();
            RolePermission = new HashSet<RolePermission>();
            UserPermission = new HashSet<UserPermission>();
        }

        public long ViewId { get; set; }
        public string ViewCode { get; set; }
        public string ViewName { get; set; }
        public string ViewDescription { get; set; }
        public long? ModuleId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Module Module { get; set; }
        public ICollection<Field> Field { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
