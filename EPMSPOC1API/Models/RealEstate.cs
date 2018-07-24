using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class RealEstate
    {
        public RealEstate()
        {
            GeneralContractorContact = new HashSet<GeneralContractorContact>();
            LandLordContact = new HashSet<LandLordContact>();
        }

        public long RealEstateId { get; set; }
        public long FacilityId { get; set; }
        public DateTime? OpenDate { get; set; }
        public string TaxIdIdentity { get; set; }
        public string RealEstateRegionIdentity { get; set; }
        public string RealEstateSchedulingProviderIdentity { get; set; }
        public string CountyIdentity { get; set; }
        public string FeeSchedule { get; set; }
        public string RegionIdentity { get; set; }
        public string Territory { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<GeneralContractorContact> GeneralContractorContact { get; set; }
        public ICollection<LandLordContact> LandLordContact { get; set; }
    }
}
