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
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Meal { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
        public int SeatNo { get; set; }
    }
}
