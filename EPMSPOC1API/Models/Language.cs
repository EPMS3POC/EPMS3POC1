using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class Language
    {
        public Language()
        {
            FacilityLanguage = new HashSet<FacilityLanguage>();
            PersonLanguage = new HashSet<PersonLanguage>();
        }

        public long LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string LanguageDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<FacilityLanguage> FacilityLanguage { get; set; }
        public ICollection<PersonLanguage> PersonLanguage { get; set; }
    }
}
