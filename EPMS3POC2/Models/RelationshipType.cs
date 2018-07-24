using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class RelationshipType
    {
        public RelationshipType()
        {
            Relationship = new HashSet<Relationship>();
        }

        public long RelationshipTypeId { get; set; }
        public string RelationshipTypeCode { get; set; }
        public string RelationshipTypeName { get; set; }
        public string RelationshipTypeDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<Relationship> Relationship { get; set; }
    }
}
