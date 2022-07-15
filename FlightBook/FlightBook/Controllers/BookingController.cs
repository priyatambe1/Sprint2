using FlightBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        FlightBookContext db;
        public BookingController(FlightBookContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblBookDetail> GetFlights()
        {
            return db.TblBookDetails;
        }
        [HttpPost]
        public string Post([FromBody] TblBookDetail bookdetail)
        {
            db.TblBookDetails.Add(bookdetail);
            db.SaveChanges();
            return "success";
        }


    }
}
    
   
