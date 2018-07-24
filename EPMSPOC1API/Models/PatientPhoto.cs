using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class PatientPhoto
    {
        public long PatientPhotoId { get; set; }
        public long PatientId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? ImageDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Patient Patient { get; set; }
    }
}
