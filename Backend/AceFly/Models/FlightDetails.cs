using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceFly.Models
{
    public class FlightDetails
    {
        public string plane_name { get; set; }
        public int no_seats { get; set; }
        public string day { get; set; }
        public double arr_time { get; set; }
        public double dept_time { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public double price_B { get; set; }
        public double price_E { get; set; }
        public int no_weeks { get; set; }
    }
}