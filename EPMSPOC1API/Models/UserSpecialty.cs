using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class UserSpecialty
    {
        public UserSpecialty()
        {
            User = new HashSet<User>();
        }

        public long UserSpecialtyId { get; set; }
        public string UserSpecialtyCode { get; set; }
        public string UserSpecialtyName { get; set; }
        public string UserSpecialtyDescription { get; set; }
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
