using System;
using System.Collections.Generic;

namespace RentalCompany.Models
{
    public partial class Equipment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Stock { get; set; }
    }
}
