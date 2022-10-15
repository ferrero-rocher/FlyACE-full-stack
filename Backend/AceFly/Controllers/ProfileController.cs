using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class ProfileController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        
        [HttpGet]
        public IHttpActionResult GetProfile(string email)
        {
            if (email != null)
            {
                try
                {
                    var result = db.user_details.Where(x => x.email == email).FirstOrDefault();
                    Profile profile = new Profile();
                    profile.FirstName = result.FirstName;
                    profile.LastName = result.LastName;
                    profile.email = result.email;
                    profile.Phoneno = result.Phoneno;
                    profile.DOB = result.DOB;
                    return Ok(profile);
                }
                catch
                {
                    return Ok();
                }
            }
            else
            {
                return Ok();
            }
        }
    }
}
