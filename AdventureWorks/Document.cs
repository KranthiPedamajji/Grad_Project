using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string Title { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string Revision { get; set; } = null!;
        public int ChangeNumber { get; set; }
        public sbyte Status { get; set; }
        public string? DocumentSummary { get; set; }
        public byte[]? Document1 { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
