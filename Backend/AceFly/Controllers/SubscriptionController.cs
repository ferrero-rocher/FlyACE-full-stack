using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class SubscriptionController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpPost]
        public IHttpActionResult Post(MarketEmail marketemail)
        {
            db.MarketEmails.Add(marketemail);
            db.SaveChanges();
            return Ok(db.MarketEmails);
        }
        [HttpGet]
        public IHttpActionResult getSubscription()
        {
            return Ok(db.MarketEmails.ToList());
        }
    }
}
