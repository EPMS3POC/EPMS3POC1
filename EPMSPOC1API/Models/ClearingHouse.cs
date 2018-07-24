using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class ClearingHouse
    {
        public ClearingHouse()
        {
            FacilityPreference = new HashSet<FacilityPreference>();
            InsurancePayerIdentity = new HashSet<InsurancePayerIdentity>();
        }

        public long ClearingHouseId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EligibilityUserName { get; set; }
        public string EligibilityPassword { get; set; }
        public long? BillingSoftwareId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public BillingSoftware BillingSoftware { get; set; }
        public ICollection<FacilityPreference> FacilityPreference { get; set; }
        public ICollection<InsurancePayerIdentity> InsurancePayerIdentity { get; set; }
    }
}
