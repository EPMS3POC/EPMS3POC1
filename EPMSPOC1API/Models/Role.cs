using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Role
    {
        public Role()
        {
            JobCode = new HashSet<JobCode>();
            RolePermission = new HashSet<RolePermission>();
        }

        public long RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<JobCode> JobCode { get; set; }
        public ICollection<RolePermission> RolePermission { get; set; }
    }
}
