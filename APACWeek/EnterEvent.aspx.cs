using Newtonsoft.Json;
using System;
using System.Collections;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APACWeek.Models;

namespace APACWeek
{
    public partial class EnterEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ENTER EVENT CODE RUNNING _____________________");
        }

        public void submitButtonEvent()
        {
            string locationName;
            string eventName;
            DateTime eventDate;
            TimeSpan eventStartTime;
            TimeSpan eventEndTime;
            string eventUrl;


            locationName = String.Format("{0}", Request.Form["location1"]);
            eventName = String.Format("{0}", Request.Form["name1"]);
            eventDate = DateTime.Parse(Request.Form["date1"]);
            eventStartTime = TimeSpan.Parse(Request.Form["startTime1"]);
            eventEndTime = TimeSpan.Parse(Request.Form["endTime1"]);
            eventUrl = String.Format("{5}", Request.Form["url1"]);

            Console.WriteLine("locaiton name: "+locationName);
            Console.WriteLine("name " + eventName);
            Console.WriteLine("Date " + eventDate);
            Console.WriteLine("Start " + eventStartTime);
            Console.WriteLine("End time " + eventEndTime);
            Console.WriteLine("Url " + eventUrl);

        }

        public void uploadEvent(Event e)
        {

        }


    }

}