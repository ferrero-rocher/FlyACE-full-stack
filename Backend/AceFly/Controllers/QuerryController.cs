using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class QuerryController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpPost]
        public IHttpActionResult addQuerry(Querry querry)
        {
            db.Querries.Add(querry);
            db.SaveChanges();
            return Ok(db.Querries);
        }
        [HttpGet]
        public IHttpActionResult getQuerries()
        {
            return Ok(db.Querries.ToList());
        }
    }
}
