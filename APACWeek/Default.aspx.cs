using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APACWeek.Models;

namespace APACWeek
{

    public partial class Default : System.Web.UI.Page
    {
        //country lat & log, set the value everytime when the country changed
        //Why need 
        private string country_lat, country_lon;

        protected void Page_Load(object sender, EventArgs e)
        {
            string Locations = GetLocations();
            
            System.Diagnostics.Trace.TraceInformation("Information");
            System.Diagnostics.Trace.TraceWarning("Warning");
            System.Diagnostics.Trace.TraceError("Error");
            #region BingMap
            //key01 - AgXKm8OLInJYX5oyF7NgYNR3hwqgg4ob8YkwakLO6QjH4qVsBEhHRD3_TCHW1118
            //key02 - As3qu8i9X85id_vVtM8aGRJu7FLLXepXmH6HiepeHBZ3E_7SiToWkPn4pPl1438n


            Literal1.Text = @"
                <script type='text/javascript' src='http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0'>
                </script>
      
                <script type='text/javascript'>

                    var  map = new Microsoft.Maps.Map(document.getElementById('myMap'), {
                            credentials: 'As3qu8i9X85id_vVtM8aGRJu7FLLXepXmH6HiepeHBZ3E_7SiToWkPn4pPl1438n'
                        });
                    
                    map.setView({
                        mapTypeId: Microsoft.Maps.MapTypeId.road,
                        center: new Microsoft.Maps.Location(" + country_lat + @", " + country_lon + @"),
                        zoom: 5
                    });

                    function GetMap() {
               
                        map.entities.clear();
                        " + Locations + @"

                        
                        function ZoomIn(e){
                            if (e.targetType == 'pushpin'){
                                var location = e.target.getLocation();                        
                                
                                map.setView({
                                    zoom:16,
                                    center: location
                                });
                            }
                        }
                    }
                </script>";
            #endregion
        } 
        public string GetCountry()
        {
            string country = "";
            string UserIP = "";
            UserIP = GetIP4Address();
            string url = "http://freegeoip.net/json/" + UserIP.ToString();
            WebClient client = new WebClient();
            string jsonstring = client.DownloadString(url);
            dynamic dynObj = JsonConvert.DeserializeObject(jsonstring);
            System.Web.HttpContext.Current.Session["country_name"] = dynObj.country_name;          
            country = dynObj.country_name;

            return country;
        }
        public string GetLocations()
        {
            PanelEvent.Visible = false;
            string Locations = "";
            string Country = "";
            List<Event> events = new List<Event>();
            List<UpEvent> Upevents = new List<UpEvent>();

            if (Page.IsPostBack)
            {
                Country = ddlCountry.SelectedValue.ToString();
            }
            else
            {
                Country = GetCountry();
            }

            try
            {
                if (Country == "Australia" || Country == "Indonesia" || Country == "Malaysia" || Country == "New Zealand" || Country == "Philippines" || Country == "Singapore" | Country =="Thailand" ||Country == "Vietnam")
                {

                    lblMsg.Text = "Based on your current located country - " + Country + " , here's the details of the event nearby you. <br /> Note : Always refer to the registration website for the latest event update in your country.";
                    //upevent - upcoming event
                    //event - past event
                    #region Australia
                    if (Country == "Australia")
                    {
                        // set the default country location

                        country_lat = "-23.021573";
                        country_lon = "133.476756";

                        #region Upcoming
                        //Up event
                        
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 9, 18, 30, 0),
                            EndDateTime = new DateTime(2017, 05, 9, 21, 0, 0),
                            Location = "Sydney",
                            EventName = "Xamarin MeetUp",
                            RegistrationUrl = "https://www.meetup.com/en-AU/SydneyMobileDotNetDevelopers/events/djqwmjywhbmb/",
                            Latitude = 0,
                            Longitude = 0
                        });
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 06, 13, 18, 30, 0),
                            EndDateTime = new DateTime(2017, 06, 13, 21, 0, 0),
                            Location = "Sydney",
                            EventName = "Xamarin MeetUp",
                            RegistrationUrl = "https://www.meetup.com/en-AU/SydneyMobileDotNetDevelopers/events/djqwmjywjbrb/",
                            Latitude = 0,
                            Longitude = 0
                        });
                        #endregion

                        #region Past
                        //Past event
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 04, 12, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 04, 12, 00, 0, 0),
                            Location = "Melbourne",
                            EventName = "Xamarin MeetUp",
                            RegistrationUrl = "https://www.meetup.com/en-AU/Melbourne-Xamarin-Meetup/",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 14, 18, 30, 0),
                            EndDateTime = new DateTime(2017, 03, 14, 21, 0, 0),
                            Location = "Sydney",
                            EventName = "Xamarin Forms Control Templates & Custom iOS Bindings",
                            RegistrationUrl = "https://www.eventbrite.com/e/bandung-developer-day-6-mobile-developer-party-tickets-31589833041",
                            Latitude = -6.408461,
                            Longitude = 108.281060
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 02, 13, 17, 00, 0),
                            EndDateTime = new DateTime(2017, 02, 13, 21, 0, 0),
                            Location = "Gold Coast Convention & Exhibition Centre",
                            EventName = "Xamarin - Getting to know MFractor and Fresh MvvM",
                            RegistrationUrl = "https://www.meetup.com/en-AU/Microsoft-events-in-Australia/events/237153716/",
                            Latitude = -28.027911,
                            Longitude = 153.428587
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 01, 25, 18, 00, 0),
                            EndDateTime = new DateTime(2017, 01, 25, 21, 0, 0),
                            Location = "Microsoft Australia, Melbourne",
                            EventName = "10 things every expert Xamarin developer needs to know",
                            RegistrationUrl = "https://www.meetup.com/en-AU/Melbourne-Xamarin-Meetup/events/236410877/",
                            Latitude = -37.821966,
                            Longitude = 144.962805
                        });

                        #endregion
                    }
                    #endregion
                    #region Indonesia
                    if (Country == "Indonesia")
                    {
                        // set the default country location

                        country_lat = "-5.672730";
                        country_lon = "108.616384";

                        #region Upcoming
                        //Up event
                        
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 17, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 17, 00, 0, 0),
                            Location = "Bandung",
                            EventName = "Xamarin Meetup with CodeLabs Unikom (Workshop)",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 17, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 17, 00, 0, 0),
                            Location = "Depok",
                            EventName = "Xamarin Meetup bersama Code Margonda Depok (Workshop)",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 21, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 21, 00, 0, 0),
                            Location = "Bandung",
                            EventName="Xamarin Party #1",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });

                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 06, 21, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 06, 21, 00, 0, 0),
                            Location = "Jakarta",
                            EventName = "Xamarin Party #2",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });

                        #endregion

                        #region Past
                        //Past event
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 05, 4, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 4, 00, 0, 0),
                            Location = "Jakarta",
                            EventName = "Xamarin workshop",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 02, 18, 9, 00, 0),
                            EndDateTime = new DateTime(2017, 02, 25, 14, 0, 0),
                            Location = "Universitas Komputer Indonesia",
                            EventName = "Bandung Developer Day #6",
                            RegistrationUrl = "https://www.eventbrite.com/e/bandung-developer-day-6-mobile-developer-party-tickets-31589833041",
                            Latitude = -6.408461,
                            Longitude = 108.281060
                        });

                        #endregion
                    }
                    #endregion
                    #region Malaysia
                    if (Country == "Malaysia")
                    {
                        // set the default country location

                        country_lat = "3.961594";
                        country_lon = "107.031977";

                        #region Upcoming
                        //Up event
                        
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 18, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 18, 00, 0, 0),
                            Location = "Microsoft Malaysia",
                            EventName = "Working with SQLite and Mobile Data  ",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 3.156669,
                            Longitude = 101.711994
                        });
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 20, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 20, 00, 0, 0),
                            Location = "Microsoft Malaysia",
                            EventName = "Xamarin Dev Days - Kuala Lumpur",
                            RegistrationUrl = "https://www.meetup.com/Malaysia-Mobile-NET-Developers-Group/events/238136574/",
                            Latitude = 3.156669,
                            Longitude = 101.711994
                        });

                        #endregion

                        #region Past
                        //Past event
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 04, 13, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 04, 13, 00, 0, 0),
                            Location = "Microsoft Malaysia",
                            EventName = "Introduction and concept of Xamarin Native and Xamarin Form",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 3.156669,
                            Longitude = 101.711994
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 05, 4, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 05, 4, 00, 0, 0),
                            Location = "Microsoft Malaysia",
                            EventName = "Consuming Web API and Services  ",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 3.156669,
                            Longitude = 101.711994
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 02, 25, 09, 30, 0),
                            EndDateTime = new DateTime(2017, 02, 25, 17, 0, 0),
                            Location = "Microsoft Malaysia",
                            EventName = "Xamarin BYOD Workshop C# - Part 1",
                            RegistrationUrl = "https://www.meetup.com/Malaysia-Mobile-NET-Developers-Group/events/230338229/%0a%0a",
                            Latitude = 0,
                            Longitude = 0
                        });


                        #endregion
                    }
                    #endregion
                    #region New Zealand
                    if (Country == "New Zealand")
                    {
                        // set the default country location

                        country_lat = "-41.788954";
                        country_lon = "171.248272";

                        #region Upcoming
                        //Up event

                        #endregion

                        #region Past
                        //Past event



                        #endregion
                    }
                    #endregion
                    #region Philippines
                    if (Country == "Philippines")
                    {
                        // set the default country location

                        country_lat = "13.999143";
                        country_lon = "120.566613";

                        //Upcoming
                        #region Upcoming
                       
                        #endregion

                        #region Past
                        //Past
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 18, 00, 00, 0),
                            EndDateTime = new DateTime(2016, 03, 19, 00, 00, 0),
                            Location = "Manila",
                            EventName = "Xamarin Event with Workshop",
                            RegistrationUrl = "",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 25, 00, 00, 0),
                            EndDateTime = new DateTime(2016, 03, 26, 00, 00, 0),
                            Location = "Manila",
                            EventName = "Xamarin Event with Workshop",
                            RegistrationUrl = "",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 12, 00, 00, 0),
                            EndDateTime = new DateTime(2016, 03, 12, 00, 00, 0),
                            Location = "Manila",
                            EventName= "Xamarin Fiesta | Mission Mars Breakout Session",
                            RegistrationUrl = "https://www.eventbrite.co.uk/e/xamarin-fiesta-manila-tickets-32319086257#",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 11, 00, 00, 0),
                            EndDateTime = new DateTime(2016, 03, 11, 00, 00, 0),
                            Location = "Davao",
                            EventName = "Xamarin Fiesta | Davao",
                            RegistrationUrl = "https://www.eventbrite.co.uk/e/xamarin-fiesta-davao-tickets-32319373115#",
                            Latitude = 0,
                            Longitude = 0
                        });
                        #endregion
                    }
                    #endregion
                    #region Singapore
                    if (Country == "Singapore")
                    {
                        // set the default country location

                        country_lat = "1.368271";
                        country_lon = "103.818856";

                        #region Upcoming
                        //Up event

                        #endregion

                        #region Past
                        //Past event
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 9, 19, 00, 0),
                            EndDateTime = new DateTime(2016, 03, 9, 22, 00, 0),
                            Location = "Microsoft Singapore, OMB",
                            EventName = "Intro to Cross Platform Development with Xamarin for Java & Android Developers",
                            RegistrationUrl = "https://www.meetup.com/mssgug/events/237157863/",
                            Latitude = 1.282392,
                            Longitude = 103.852437
                        });


                        #endregion
                    }
                    #endregion
                    #region Thailand
                    if (Country == "Thailand")
                    {
                        // set the default country location

                        country_lat = "15.258589";
                        country_lon = "100.771860";
                        #region Upcoming

                        #endregion
                        #region Past
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 24, 13, 00, 0),
                            EndDateTime = new DateTime(2017, 03, 24, 00, 00, 0),
                            Location = "Microsoft Thailand",
                            EventName = "Visual Studio 2017 Launch",
                            RegistrationUrl = "https://www.meetup.com/Digital-Thailand-Club-Meetup/events/238209281/",
                            Latitude = 13.731119,
                            Longitude = 100.569720
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 02, 24, 00, 00, 0),
                            EndDateTime = new DateTime(2017, 02, 24, 00, 00, 0),
                            Location = "",
                            EventName = "Xamarin Mission#1",
                            RegistrationUrl = "",
                            Latitude = 13.731119,
                            Longitude = 100.569720
                        });


                        #endregion
                    }
                    #endregion
                    #region VietNam
                    if (Country == "Vietnam")
                    {
                        // set the default country location

                        country_lat = "10.877407";
                        country_lon = "108.648612";

                        #region Upcoming
                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 20, 8, 30, 0),
                            EndDateTime = new DateTime(2017, 05, 20, 17, 30, 0),
                            Location = "272 Conference, HCMC",
                            EventName = "Mobile Day 2017",
                            RegistrationUrl = "http://mobileday.vn/en/homepage/",
                            Latitude = 10.779121,
                            Longitude = 106.683077
                        });

                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 05, 27, 08, 30, 0),
                            EndDateTime = new DateTime(2017, 05, 27, 17, 30, 0),
                            Location = "Forevermark Conference, Hanoi",
                            EventName = "Mobile Day 2017",
                            RegistrationUrl = "http://mobileday.vn/en/homepage/",
                            Latitude = 21.075710,
                            Longitude = 105.816063
                        });

                        Upevents.Add(new UpEvent()
                        {
                            StartDateTime = new DateTime(2017, 06, 03, 08, 30, 0),
                            EndDateTime = new DateTime(2017, 06, 03, 12, 00, 0),
                            Location = "One Opera Hotel, Danang",
                            EventName = "Mobile Day 2017",
                            RegistrationUrl = "http://mobileday.vn/en/homepage/",
                            Latitude = 16.0595596,
                            Longitude = 108.2087691
                        });
                        #endregion

                        #region Past
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 04, 8, 0, 00, 0),
                            EndDateTime = new DateTime(2017, 04, 8, 0, 00, 0),
                            Location = "Microsoft Viet Nam, Hanoi",
                            EventName = "Xamarin.Forms Workshop",
                            RegistrationUrl = "https://aka.ms/xamarinlabs/xamarin.forms-hn",
                            Latitude = 21.023815,
                            Longitude = 105.842188
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 04, 15, 0, 00, 0),
                            EndDateTime = new DateTime(2017, 04, 15, 0, 00, 0),
                            Location = "Microsoft Viet Nam, Hanoi",
                            EventName = "Xamarin.Forms Workshop",
                            RegistrationUrl = "https://aka.ms/xamarinlabs/xamarin.forms-hn",
                            Latitude = 21.023815,
                            Longitude = 105.842188
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 25, 9, 00, 0),
                            EndDateTime = new DateTime(2017, 03, 25, 12, 00, 0),
                            Location = "Microsoft Viet Nam - Hanoi",
                            EventName = "Mission Mars@Xamarin",
                            RegistrationUrl = "https://aka.ms/missionmars-hn",
                            Latitude = 21.023815,
                            Longitude = 105.842188
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 25, 9, 00, 0),
                            EndDateTime = new DateTime(2017, 03, 25, 12, 00, 0),
                            Location = "Microsoft Viet Nam - HCMC",
                            EventName = "Mission Mars@Xamarin",
                            RegistrationUrl = "https://www.facebook.com/events/384688788569970/",
                            Latitude = 21.023815,
                            Longitude = 105.842188
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 18, 9, 00, 0),
                            EndDateTime = new DateTime(2017, 03, 18, 12, 00, 0),
                            Location = "Microsoft Viet Nam - Hanoi",
                            EventName = "Xamarin.Forms Workshop",
                            RegistrationUrl = "https://www.facebook.com/events/1234564909990561/",
                            Latitude = 21.023815,
                            Longitude = 105.842188
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 03, 25, 0, 00, 0),
                            EndDateTime = new DateTime(2017, 03, 25, 0, 00, 0),
                            Location = "Hanoi",
                            EventName = "Xamarin.Forms Workshop",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 04, 1, 0, 00, 0),
                            EndDateTime = new DateTime(2017, 04, 1, 0, 00, 0),
                            Location = "Hanoi",
                            EventName = "Xamarin.Forms Workshop",
                            RegistrationUrl = "Coming Soon",
                            Latitude = 0,
                            Longitude = 0
                        });
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2017, 2, 24, 14, 30, 0),
                            EndDateTime = new DateTime(2017, 2, 24, 17, 30, 0),
                            Location = "PJ's Coffee - Sala Store",
                            EventName= "TRG Developers Meetup : Azure + Xamarin (Cross Platform Development)",
                            RegistrationUrl = "https://xamarin-developers-trg-microsoft.eventbrite.com",
                            Latitude = 0,
                            Longitude = 0
                        });
                        
                        #endregion
                    }
                    #endregion

                    MsgPanel.CssClass = string.Empty;
                    MsgPanel.CssClass = "alert alert-info";
                }

                else
                {
                    MsgPanel.CssClass = string.Empty;
                    MsgPanel.CssClass = "alert alert-warning";
                    lblMsg.Text = "Sorry but we can't find any event located in your country - " + Country + ". This event is only available at Australia, Indonesia, Malaysia, New Zealand, Singapore, Philippines, Thailand and Vietnam. <br />You may use the below dropdown list to manually select your country.";
                }
            }
            catch { }

            //Past event
            EventRepeater.DataSource = events;
            EventRepeater.DataBind();

            //Up event
            UpcomingEventRepeater.DataSource = Upevents;
            UpcomingEventRepeater.DataBind();

            PanelEvent.Visible = (events.Count == 0) ? false : true;
            PanelNoEvent.Visible = !PanelEvent.Visible;

            foreach (var ev in Upevents)
            {
                Locations += "var pushpin = new Microsoft.Maps.Pushpin(new Microsoft.Maps.Location(" + ev.Latitude.ToString() + ", " + ev.Longitude.ToString() + "), null);Microsoft.Maps.Events.addHandler(pushpin, 'click', ZoomIn);map.entities.push(pushpin);";
            }
           
            return Locations;
        }
        public static string GetIP4Address()
        {
            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            if (IP4Address != String.Empty)
            {
                return IP4Address;
            }

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            return IP4Address;
        }

    }
}