using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class DocumentSubCategory
    {
        public DocumentSubCategory()
        {
            DocumentManagement = new HashSet<DocumentManagement>();
        }

        public long DocumentSubCategoryId { get; set; }
        public long DocumentCategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string DisplayName { get; set; }
        public string SubCatgoryFileName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public DocumentCategory DocumentCategory { get; set; }
        public ICollection<DocumentManagement> DocumentManagement { get; set; }
    }
}
