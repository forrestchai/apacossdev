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
            System.Diagnostics.Debug.WriteLine("ENTER EVENT CODE RUNNING _____________________");
        }

        public void submitButtonEvent(object sender, EventArgs e)
        {
            string locationName;
            string eventName;
            DateTime eventDate;
            TimeSpan eventStartTime;
            TimeSpan eventEndTime;
            string eventUrl;


            locationName = location1.Value; //String.Format("{0}", Request.Form["location1"]);
            eventName = name1.Value; //String.Format("{0}", Request.Form["name1"]);
            eventDate = DateTime.Parse(date1.Value); //DateTime.Parse(Request.Form["date1"]);
            eventStartTime = TimeSpan.Parse(startTime1.Value); //TimeSpan.Parse(Request.Form["startTime1"]);
            eventEndTime = TimeSpan.Parse(endTime1.Value); //TimeSpan.Parse(Request.Form["endTime1"]);
            eventUrl = url1.Value; //String.Format("{5}", Request.Form["url1"]);

            System.Diagnostics.Debug.WriteLine("locaiton name: "+locationName);
            System.Diagnostics.Debug.WriteLine("name " + eventName);
            System.Diagnostics.Debug.WriteLine("Date " + eventDate);
            System.Diagnostics.Debug.WriteLine("Start " + eventStartTime);
            System.Diagnostics.Debug.WriteLine("End time " + eventEndTime);
            System.Diagnostics.Debug.WriteLine("Url " + eventUrl);

        }

        public void uploadEvent(Event e)
        {

        }


    }

}