using System;
using System.Collections.Generic;

namespace APACWeek.Models
{
    public class UpEvent
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        public string EventName { get; set; }
        public string RegistrationUrl { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}