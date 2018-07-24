using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class LocationStatus
    {
        public LocationStatus()
        {
            Entity = new HashSet<Entity>();
            Facility = new HashSet<Facility>();
        }

        public long LocationStatusId { get; set; }
        public string LocationStatusDescription { get; set; }
        public string LocationStatusCode { get; set; }
        public string LocationStatusName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Entity> Entity { get; set; }
        public ICollection<Facility> Facility { get; set; }
    }
}
