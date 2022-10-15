using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AceFly.Models;

namespace AceFly.Models
{
    public class CardInputs
    { 

        public List<PassengerDetails> passengersinfo = new List<PassengerDetails>();
    public long Card_No { get; set; }
    public string Card_HolderName { get; set; }
    public string Card_Type { get; set; }
    public System.DateTime Expires { get; set; }
    public int CVV { get; set; }
    public string email { get; set; }
    public double amount { get; set; }
    public string TansactionType { get; set; }
    }
}