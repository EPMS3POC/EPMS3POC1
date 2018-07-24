using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Finance
    {
        public Finance()
        {
            CollectionAgency = new HashSet<CollectionAgency>();
            Lender = new HashSet<Lender>();
        }

        public long FinanceId { get; set; }
        public long FacilityId { get; set; }
        public string FinanceRegion { get; set; }
        public string FinancialClassAccountGroup { get; set; }
        public string FinanceName { get; set; }
        public string FinanceDescription { get; set; }
        public string FinanceCode { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Facility Facility { get; set; }
        public ICollection<CollectionAgency> CollectionAgency { get; set; }
        public ICollection<Lender> Lender { get; set; }
    }
}
