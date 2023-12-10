using System;
using System.Collections.Generic;

namespace Grad_Project.Models
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int? ProductId { get; set; }
        public decimal? RatingValue { get; set; }
        public string? Comment { get; set; }
        public DateTime? RatingDate { get; set; }

        public virtual Product? Product { get; set; }
    }
}
