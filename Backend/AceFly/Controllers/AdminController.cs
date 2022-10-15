using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class AdminController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpGet]
        public IHttpActionResult viewFlights()
        {
            return Ok(db.prc_ViewSchedule().ToList());
        }
        [HttpPost]
        public IHttpActionResult addFlight(FlightDetails fd)
        {
            db.prc_AddFlights(fd.plane_name, fd.no_seats, fd.day, TimeSpan.FromHours(fd.arr_time), TimeSpan.FromHours(fd.dept_time), fd.source, fd.destination, fd.price_B, fd.price_E, fd.no_weeks);
            return Ok(db.Planes.ToList());
        }
        [HttpPut]
        //public IHttpActionResult deleteSchedule(string scheduleId)
        //{
        //    Schedule s = db.Schedules.Where(x => x.Schedule_Id.ToString() == scheduleId).FirstOrDefault();
        //    s.isAvailability = !s.isAvailability;
        //    db.SaveChanges();
        //    return Ok("Schedule Deleted!");
        //}
        public IHttpActionResult deleteSchedule(string scheduleId)
        {
            db.prc_DisableSchedule(scheduleId);
            return Ok(db.prc_ViewSchedule().ToList());
        }
    }
}
