using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class Marketing
    {
        public Marketing()
        {
            MessageTarget = new HashSet<MessageTarget>();
            Promotion = new HashSet<Promotion>();
        }

        public long MarketingId { get; set; }
        public long FacilityId { get; set; }
        public string MarketingArea { get; set; }
        public string WebsiteName { get; set; }
        public string WebsiteMarketingPlaza { get; set; }
        public string WebsiteGeolocation { get; set; }
        public string WebsiteNeighboringAreas { get; set; }
        public string WebsiteComments { get; set; }
        public string WebsiteActive { get; set; }
        public string Dma { get; set; }
        public string PricingRegions { get; set; }
        public string OfferDisclaimers { get; set; }
        public string ExternalMarketingName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<MessageTarget> MessageTarget { get; set; }
        public ICollection<Promotion> Promotion { get; set; }
    }
}
