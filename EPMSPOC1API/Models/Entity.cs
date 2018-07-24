using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Entity
    {
        public Entity()
        {
            EntityAddress = new HashSet<EntityAddress>();
            EntityMappingLog = new HashSet<EntityMappingLog>();
            EntityPhone = new HashSet<EntityPhone>();
            User = new HashSet<User>();
        }

        public long EntityId { get; set; }
        public long OrganizationId { get; set; }
        public long? LocationStatusId { get; set; }
        public string ExternalMarketingName { get; set; }
        public short? IsHeadQuarter { get; set; }
        public string WebsiteAddress { get; set; }
        public string EmailIdentifier { get; set; }
        public string EntityDescription { get; set; }
        public string EntityCode { get; set; }
        public string EntityName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public LocationStatus LocationStatus { get; set; }
        public Organization Organization { get; set; }
        public ICollection<EntityAddress> EntityAddress { get; set; }
        public ICollection<EntityMappingLog> EntityMappingLog { get; set; }
        public ICollection<EntityPhone> EntityPhone { get; set; }
        public ICollection<User> User { get; set; }
    }
}
