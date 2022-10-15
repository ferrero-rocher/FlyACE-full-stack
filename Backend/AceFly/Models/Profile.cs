using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceFly.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public long Phoneno { get; set; }
        public System.DateTime DOB { get; set; }
    }
}