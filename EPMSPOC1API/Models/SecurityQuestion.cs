using System;
using System.Collections.Generic;

namespace EPMS3POC1.Models
{
    public partial class SecurityQuestion
    {
        public SecurityQuestion()
        {
            User = new HashSet<User>();
        }

        public long SecurityQuestionId { get; set; }
        public string SecurityQuestionCode { get; set; }
        public string SecurityQuestionName { get; set; }
        public string SecurityQuestionDescription { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<User> User { get; set; }
    }
}
