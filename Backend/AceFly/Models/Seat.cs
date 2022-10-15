using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceFly.Models
{
    public class Seat
    {
        public string row { get; set; }
        public string letter { get; set; }
        public Nullable<bool> isAvailable { get; set; }
        public string seatClass { get; set; }
        public bool check { get; set; }
    }
}