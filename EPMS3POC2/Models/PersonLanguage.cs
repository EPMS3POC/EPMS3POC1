using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PersonLanguage
    {
        public long PersonLanguageId { get; set; }
        public long PersonId { get; set; }
        public int? IsPersonLanguagePreference { get; set; }
        public long LanguageId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Language Language { get; set; }
        public Person Person { get; set; }
    }
}
