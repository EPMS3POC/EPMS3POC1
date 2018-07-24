using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Field
    {
        public Field()
        {
            RolePermission = new HashSet<RolePermission>();
            UserPermission = new HashSet<UserPermission>();
        }

        public long FieldId { get; set; }
        public string FieldCode { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? ViewId { get; set; }

        public View View { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
