using System;
using System.Collections.Generic;

namespace RentalCompany.Models
{
    public partial class Rental
    {
        public int Id { get; set; }
        public int? RentalHours { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsCurrent { get; set; }
        public string CustomerUserName { get; set; } = null!;
        public int EquipmentId { get; set; }
    }   
}
        