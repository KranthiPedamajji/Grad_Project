﻿using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Productcategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}
