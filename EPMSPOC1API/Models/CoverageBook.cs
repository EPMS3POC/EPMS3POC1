using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class CoverageBook
    {
        public CoverageBook()
        {
            CoverageFrequency = new HashSet<CoverageFrequency>();
            CoverageLimit = new HashSet<CoverageLimit>();
            CoverageProcedure = new HashSet<CoverageProcedure>();
        }

        public long CoverageBookId { get; set; }
        public long? InsuranceId { get; set; }
        public long? PatientId { get; set; }
        public long? SubscriberId { get; set; }
        public string CoverageName { get; set; }
        public string PlanName { get; set; }
        public long? InsurancePayerId { get; set; }
        public long? CoverageBookTypeId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public CoverageBookType CoverageBookType { get; set; }
        public Insurance Insurance { get; set; }
        public InsurancePayer InsurancePayer { get; set; }
        public Patient Patient { get; set; }
        public Subscriber Subscriber { get; set; }
        public ICollection<CoverageFrequency> CoverageFrequency { get; set; }
        public ICollection<CoverageLimit> CoverageLimit { get; set; }
        public ICollection<CoverageProcedure> CoverageProcedure { get; set; }
    }
}
