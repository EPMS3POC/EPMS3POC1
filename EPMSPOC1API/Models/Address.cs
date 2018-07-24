using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Address
    {
        public Address()
        {
            DiagnosticCenterAddress = new HashSet<DiagnosticCenterAddress>();
            EntityAddress = new HashSet<EntityAddress>();
            FacilityAddress = new HashSet<FacilityAddress>();
            GeoCode = new HashSet<GeoCode>();
            InsuranceAddress = new HashSet<InsuranceAddress>();
            PersonAddress = new HashSet<PersonAddress>();
        }

        public long AddressId { get; set; }
        public long? ZipCodeId { get; set; }
        public long? CountyId { get; set; }
        public string SpecialInstructions { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }

        public City City { get; set; }
        public County County { get; set; }
        public State State { get; set; }
        public ZipCode ZipCode { get; set; }
        public ICollection<DiagnosticCenterAddress> DiagnosticCenterAddress { get; set; }
        public ICollection<EntityAddress> EntityAddress { get; set; }
        public ICollection<FacilityAddress> FacilityAddress { get; set; }
        public ICollection<GeoCode> GeoCode { get; set; }
        public ICollection<InsuranceAddress> InsuranceAddress { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
    }
}
