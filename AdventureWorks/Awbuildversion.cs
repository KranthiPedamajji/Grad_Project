using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Awbuildversion
    {
        public int SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; } = null!;
        public DateTime VersionDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
