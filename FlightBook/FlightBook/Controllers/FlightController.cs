﻿using FlightBook.Models;
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
    public class FlightController : ControllerBase
    {
        FlightBookContext db;
        public FlightController(FlightBookContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblFlight> GetFlights()
        {
            return db.TblFlights;
        }
        [HttpPost]
        public string Post([FromBody] TblFlight flight)
        {
           /* if (flight.IsActive == 1)
            {
                db.SaveChanges();
            }
            else
                return "no";*/
            db.TblFlights.Add(flight);
            db.SaveChanges();
            return "success";
        }
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var flight = db.TblFlights.Where(x => x.Id == Id).FirstOrDefault();
            if (flight != null)
            {
                db.TblFlights.Remove(flight);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
        [HttpPut]
        public string Put([FromBody] TblFlight tblsample)
        {
            var tblsampleObj = db.TblFlights.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.TblFlights.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}
    