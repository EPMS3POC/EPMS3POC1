using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Entity = new HashSet<Entity>();
            User = new HashSet<User>();
        }

        public long OrganizationId { get; set; }
        public long? LocationStatusId { get; set; }
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Entity> Entity { get; set; }
        public ICollection<User> User { get; set; }
    }
}
