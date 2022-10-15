using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class TicketsController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpGet]
        public IHttpActionResult getTickects(string email)
        {
            return Ok(db.prc_displayTicket(email).ToList());
        }
    }
}
