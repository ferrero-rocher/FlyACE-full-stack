//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AceFly.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public int Flight_ID { get; set; }
        public string seatNo { get; set; }
        public string schedule_ID { get; set; }
        public string ticket_ID { get; set; }
        public Nullable<bool> isAvailable { get; set; }
        public string seatClass { get; set; }
    
        public virtual Schedule Schedule { get; set; }
    }
}
