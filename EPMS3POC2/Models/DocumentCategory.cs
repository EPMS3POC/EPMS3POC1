using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DocumentCategory
    {
        public DocumentCategory()
        {
            DocumentManagement = new HashSet<DocumentManagement>();
            DocumentMapping = new HashSet<DocumentMapping>();
            DocumentSubCategory = new HashSet<DocumentSubCategory>();
        }

        public long DocumentCategoryId { get; set; }
        public string DocumentCategoryDescription { get; set; }
        public string DocumentCategoryCode { get; set; }
        public string DocumentCategoryName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public ICollection<DocumentManagement> DocumentManagement { get; set; }
        public ICollection<DocumentMapping> DocumentMapping { get; set; }
        public ICollection<DocumentSubCategory> DocumentSubCategory { get; set; }
    }
}
