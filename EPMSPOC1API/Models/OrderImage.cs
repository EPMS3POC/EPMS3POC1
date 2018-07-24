using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class OrderImage
    {
        public OrderImage()
        {
            OrderImageDiagnosticTestCategory = new HashSet<OrderImageDiagnosticTestCategory>();
        }

        public long OrderImageId { get; set; }
        public string OrderImagesGuid { get; set; }
        public DateTime? OrderImagesDate { get; set; }
        public string Priority { get; set; }
        public string OpenWounds { get; set; }
        public string Jewelry { get; set; }
        public string PatientComfortableEnclosedSpaces { get; set; }
        public string PatientLieOnBack { get; set; }
        public string RiskOfFall { get; set; }
        public short? Pregnent { get; set; }
        public short? Spine { get; set; }
        public short? Lbs { get; set; }
        public short? Diabetics { get; set; }
        public DateTime? ScheduledTestDate { get; set; }
        public string Indications { get; set; }
        public short? IsElectronic { get; set; }
        public long PatientId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }
        public long? DiagnosticCenterId { get; set; }

        public DiagnosticCenter DiagnosticCenter { get; set; }
        public Patient Patient { get; set; }
        public ICollection<OrderImageDiagnosticTestCategory> OrderImageDiagnosticTestCategory { get; set; }
    }
}
