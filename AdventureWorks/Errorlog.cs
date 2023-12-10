using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Errorlog
    {
        public int ErrorLogId { get; set; }
        public DateTime ErrorTime { get; set; }
        public string UserName { get; set; } = null!;
        public int ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public string? ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; } = null!;
    }
}
