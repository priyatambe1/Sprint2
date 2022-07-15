using System;
using System.Collections.Generic;

#nullable disable

namespace FlightBook.Models
{
    public partial class TblBookDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassengerDetails { get; set; }
        public string Meal { get; set; }
        public int? SeatNo { get; set; }
    }
}
