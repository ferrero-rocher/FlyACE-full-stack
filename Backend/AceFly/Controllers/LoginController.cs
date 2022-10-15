using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class LoginController : ApiController
    { 
        FlyAceEntities db = new FlyAceEntities();
        [HttpPost]
        public IHttpActionResult Post(Login login)
        { 


            var result = db.user_details.Where(x => x.email == login.email && x.password == login.password).FirstOrDefault();
            if (result != null)
            {
                return Ok(result.email);
            }
            else
            {
                return Ok();
            }
        }
    }
}
