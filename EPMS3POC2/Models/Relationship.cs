using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Relationship
    {
        public long RelationshipId { get; set; }
        public long PersonId { get; set; }
        public long PatientId { get; set; }
        public long RelationshipTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Patient Patient { get; set; }
        public Person Person { get; set; }
        public RelationshipType RelationshipType { get; set; }
    }
}
