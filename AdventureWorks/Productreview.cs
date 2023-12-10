using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productreview
    {
        public int ProductReviewId { get; set; }
        public int ProductId { get; set; }
        public string? ReviewerName { get; set; }
        public DateTime ReviewDate { get; set; }
        public string? EmailAddress { get; set; }
        public int Rating { get; set; }
        public string? Comments { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
