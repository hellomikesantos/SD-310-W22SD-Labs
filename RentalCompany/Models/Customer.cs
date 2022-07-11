using System;
using System.Collections.Generic;

namespace RentalCompany.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public int? RentalHours { get; set; }

    }
}
