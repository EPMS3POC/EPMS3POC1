using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            User = new HashSet<User>();
        }

        public long UserStatusId { get; set; }
        public string UserStatusCode { get; set; }
        public string UserStatusName { get; set; }
        public string UserStatusDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<User> User { get; set; }
    }
}
