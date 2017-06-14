using System;
using System.Collections.Generic;

namespace APACWeek.Models
{
    public class Event
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public String Location { get; set; }
        public String EventName { get; set; }
        public String RegistrationUrl { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }


        public Event(){}

        public Event(DateTime date, TimeSpan start, TimeSpan end, String loca, String name, String url)//, double longi, double lati)
        {
            this.StartDateTime = date+start;
            this.EndDateTime = date+end;
            this.Location = loca;
            this.EventName = name;
            this.RegistrationUrl = url;
            //this.Longitude = longi;
            //this.Latitude = lati;
        }

    }

}