using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class FacilityLanguage
    {
        public long FacilityLanguageId { get; set; }
        public long? FacilityId { get; set; }
        public long? LanguageId { get; set; }

        public Language Language { get; set; }
    }
}
