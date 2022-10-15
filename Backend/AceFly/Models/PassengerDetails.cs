using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceFly.Models
{
    public class PassengerDetails
    {
        public string passenger_name { get; set; }
        public string seatNo { get; set; }
        public string document_type { get; set; }
        public string document_no { get; set; }
        public string Schedule_Id { get; set; }
        public string Passenger_type { get; set; }
    }
}