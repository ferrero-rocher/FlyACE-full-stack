using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class RegisterController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpPost]
        public IHttpActionResult Post(user_details register)
        {
            db.user_details.Add(register);
            db.SaveChanges();
            return Ok(db.user_details);
        }
        [HttpGet]
        public IHttpActionResult getUsers()
        {
            return Ok(db.user_details.ToList());
        }
    }
}
