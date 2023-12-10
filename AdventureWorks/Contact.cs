using System;
using System.Collections.Generic;

namespace Grad_Project.AdventWorksModel
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public ulong NameStyle { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public string? EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        public string? Phone { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public string? AdditionalContactInfo { get; set; }
        public byte[] Rowguid { get; set; } = null!;
        public DateTime ModifiedDate { get; set; }
    }
}
