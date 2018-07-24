using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Prospect
    {
        public long ProspectId { get; set; }
        public string CallerFirstName { get; set; }
        public string CallerLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public long? GenderId { get; set; }
        public double? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public long? PhoneType { get; set; }
        public string EmailAddress { get; set; }
        public long VisitReasonId { get; set; }
        public double? CallDate { get; set; }
        public long? FacilityId { get; set; }
        public long? VisitReasonTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public VisitReasonType VisitReasonType { get; set; }
    }
}
