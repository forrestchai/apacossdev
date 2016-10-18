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
        private string country_lat, country_lon;

        protected void Page_Load(object sender, EventArgs e)
        {
            string Locations = GetLocations();
            speakerList();

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
        public void speakerList()
        {
            var Speakers = new List<Speaker>();
            //Keynote
            Speakers.Add(new Speaker()
            {
                Name = $"Janakiram MSV (Keynote)",
                Country = "India",
                PhotoPath = "images\\janakiram.PNG",
                Profile = $"Janakiram MSV is an analyst, advisor and an architect at Janakiram & Associates. He was the founder and CTO of Get Cloud Ready Consulting, a niche Cloud Migration and Cloud Operations firm that got acquired by Aditi Technologies. Through his speaking, writing and analysis, he helps businesses take advantage of the emerging technologies. Janakiram is one of the first few Microsoft Certified Azure Professionals in India. He is one of the few professionals with Amazon Certified Solution Architect, Amazon Certified Developer and Amazon Certified SysOps Administrator credentials. He is also a Google Qualified Cloud Developer. Janakiram is recognised by Google as the Google Developer Expert (GDE) for his subject matter expertise. He is awarded the title of Regional Director by Microsoft Corporation."
            });
            //Influencers Australia
            Speakers.Add(new Speaker()
            {
                Name = $"Martin Abbott",
                Country = "Australia",
                PhotoPath = "images\\martin.PNG",
                Profile = $"An experienced Architect with over 10 years experience designing and developing software and integration solutions for a diverse range of organizations including financial sector and government. Experience of working across all parts of customer engagement, from pre-sales and bid work to project delivery and support. Recently being appointed CTO at Satalyst in Perth, I’m an Agile development advocate, strong on using process and governance to drive quality."
            });
            //Influencers Australia
            Speakers.Add(new Speaker()
            {
                Name = $"Mick Badran",
                Country = "Australia",
                PhotoPath = "images\\mick.PNG",
                Profile = $"Mick has a strong applied technical focus predominately in the Application Integration space, from interactive endpoints through to Analytics and BI stacks. High performance near real time interfaces is his specialty. Mick is a Microsoft Azure Integration MVP with a strong focus on Integration stacks Having an equal balance between training and the consulting worlds with 15 years of leading a technical team to create innovative solutions."
            });

            //Influencers Indonesia
            Speakers.Add(new Speaker()
            {
                Name = $"Muhammad Ibnu Fadhil",
                Country = "Indonesia",
                PhotoPath = "images\\fadhil.PNG",
                Profile = $"I’m an entrepreneur, coder, and community contributor. In 2010, my friends and I have established our own start-up, Gravicode. we provide consultation services and software development solution with Microsoft based framework. In my daily activities, I conduct my own research by adopting new technology, share it on a blog and use it on our solution to our customers. Currently, I would like to give more contribution to the IT community. My interests are mostly in cloud, mobile and IoT. As a software development professional, I’ve been managing and developing more than 30 software projects."
            });
            //Influencers Indonesia
            Speakers.Add(new Speaker()
            {
                Name = $"Andri Yadi",
                Country = "Indonesia",
                PhotoPath = "images\\andri.PNG",
                Profile = $"Being an autodidactic entrepreneur for 12 years, he has co-founded 4 software companies since 2003 and his last company, DyCode, has been around for 8 years and has become an award-winning, high profile software development company in Indonesia. Under DyCode, he co-created two well-known products, Movreak and Jepret, that both have won 6 awards so far and already well-monetized."
            });
            //Influencers Korea
            Speakers.Add(new Speaker()
            {
                Name = $"Min-Gyu Ju",
                Country = "Korea",
                PhotoPath = "images\\mingyu.PNG",
                Profile = $"Min-Gyu Ju is the CEO of RecursiveSoft, Inc. which builds IoT devices specialized in Bluetooth Smart Mesh. He is focused to re-define THINGS and connect them to our lives. He is an affiliated professor of Youngsan University in Busan and also leads the community ‘Smart App Developer Forum’ with more than 3K members."
            });
            //Influencers Malaysia
            Speakers.Add(new Speaker()
            {
                Name = $"Chia Shaw Chyn",
                Country = "Malaysia",
                PhotoPath = "images\\chia.PNG",
                Profile = $"Chia, a passionate Windows Mobile developer, early adopters for Universal Windows Platform, actively develop local contents apps on UWP. As a MVP and MCT, Chia is always sharing his knowledge with the local communities."
            });
            //Influencers New Zealand
            Speakers.Add(new Speaker()
            {
                Name = $"John McDermott",
                Country = "New Zealand",
                PhotoPath = "images\\john.PNG",
                Profile = $"John McDermott is an Internet of Things entrepreneur and runs the IoT Auckland Meetup group.  He is an electronics and software engineer, with extensive product management and marketing experience in telecom and utility industries.  John has interests in several wireless technologies from NFC to LPWAN, and is using these to create new IoT applications.  The IoT Auckland Meetup group has over 500 members and meets monthly to discover new technologies, applications and opportunities."
            });
            //Influencers Philippines
            Speakers.Add(new Speaker()
            {
                Name = $"Christopher Misola",
                Country = "Philippines",
                PhotoPath = "images\\chris.PNG",
                Profile = $"Chris was a technical evangelist in Microsoft for 4 years. With great skill set and knowledge in the field of IT, he is currently leading the community on Azure IoT."
            });
            //Influencers Sri Lanka
            Speakers.Add(new Speaker()
            {
                Name = $"Shameera Prajapriya",
                Country = "Sri Lanka",
                PhotoPath = "images\\shameera.PNG",
                Profile = $"Shameera, Solution Architect from LAUGFS Holdings Limited Sri Lanka, started re-working on some architectures on the projects he was working on, based on the bunch of new things he learnt at the camp. After the training event, he is planning to write few blog lessons related to Azure IoT Hub / Cognitive Services and ML with all the development steps."
            });
            //Influencers Sri Lanka
            Speakers.Add(new Speaker()
            {
                Name = $"Gayan Dissanayake",
                Country = "Sri Lanka",
                PhotoPath = "images\\gayan.PNG",
                Profile = $"Gayan is an Solution Architect from nCinga innovations. His company solution is tremendously in the implementation of the solution nCinga based on Azure."
            });
            //Influencers Thailand
            Speakers.Add(new Speaker()
            {
                Name = $"Teerachai Laothong",
                Country = "Thailand",
                PhotoPath = "images\\teerachai.PNG",
                Profile = $"Teerachai is a Microsoft Certified Trainer at IMC Institute, one of the most influential technical training center in Thailand.  IMC Institute was found by Dr.Thanachart who is now one of the key local influencer, esp. among Government agencies, OSS/Java community."
            });
            //Influencers Vietnam
            Speakers.Add(new Speaker()
            {
                Name = $"Nguyen Hoang Anh Tuan",
                Country = "Vietnam",
                PhotoPath = "images\\nguyen.PNG",
                Profile = $"Tuan is working for Bosch Vietnam as an embed system engineer/developer and many other projects related to IoT and embed system in the past, car embed device is looked like a IoT device which is embed in car to look after car’s status and car’s software. He also a co-founder of http://raspi.vn/ , a community for Raspberry PI device’s fan club (run Windows 10 for IoT/Linux) which has reach 5000 followers."
            });
            //Influencers Vietnam
            Speakers.Add(new Speaker()
            {
                Name = $"Pham Tat Dat ",
                Country = "Vietnam",
                PhotoPath = "images\\pham.PNG",
                Profile = $"Dat is a technical consultant for some companies he also works on IoT projects. He is technical expert, but hasn’t been active community influencer now. However, he is potential influencer for Microsoft technologies as he has good impact to enterprise companies. He also agree to contribute for communities from now on, it is reason why we would like to nominate him for this, it will help a lot for Vietnam tech communities."
            });
            SpeakerRepeater.DataSource = Speakers;
            SpeakerRepeater.DataBind();
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
                if (Country == "Australia" || Country == "Indonesia" || Country == "Korea" || Country == "Malaysia" || Country == "New Zealand" || Country == "Philippines" || Country == "Sri Lanka" || Country == "Vietnam" || Country == "Thailand")
                {

                    lblMsg.Text = "Based on your current located country - " + Country + " , here's the details of the event nearby you. <br /> Note : Always refer to the registration website for the latest event update in your country.";

                    if (Country == "Australia")
                    {
                        // set the default country location

                        country_lat = "-32.759040";
                        country_lon = "131.713842";

                        //Sydney
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 17, 0, 0),
                            Location = "Microsoft Store - Westfield Sydney on Pitt Street Mall",
                            RegistrationUrl = "https://www.meetup.com/en-AU/Microsoft-events-in-Australia/events/234795003/",
                            Latitude = -33.870651,
                            Longitude = 151.207138
                        });

                        //Perth
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 17, 0, 0),
                            Location = "Microsoft Australia, Perth",
                            RegistrationUrl = "http://www.meetup.com/Perth-Cloud/events/234771275/",
                            Latitude = -31.954381,
                            Longitude = 115.857530
                        });
                    }
                    if (Country == "Indonesia")
                    {
                        // set the default country location

                        country_lat = "-5.672730";
                        country_lon = "108.616384";

                        //Bogor
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 30, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 16, 0, 0),
                            Location = "Hotel Amaris Pakuan Bogor",
                            RegistrationUrl = "https://www.eventbrite.com/e/apac-azure-iot-weekend-indonesia-tickets-28518508627",
                            Latitude = -6.606750,
                            Longitude = 106.810349
                        });

                    }
                    if (Country == "Korea")
                    {
                        // set the default country location                      
                        country_lat = "37.810347 ";
                        country_lon = "126.995174";

                        //Busan
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 13, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 17, 0, 0),
                            Location = "Busan Design Center",
                            RegistrationUrl = "http://onoffmix.com/event/81103",
                            Latitude = 35.173999,
                            Longitude = 129.129876
                        });
                    }
                    if (Country == "Malaysia")
                    {
                        // set the default country location

                        country_lat = "3.254700";
                        country_lon = "107.874187";

                        // get event(s) details, and add it to events collection
                        //Kuala Lumpur
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 17, 0, 0),
                            Location = "Microsoft Malaysia, Kuala Lumpur",
                            RegistrationUrl = "https://www.meetup.com/Microsoft-Developer-Malaysia/events/234587811/",
                            Latitude = 3.156591,
                            Longitude = 101.711282
                        });


                    }
                    if (Country == "New Zealand")
                    {
                        // set the default country location

                        country_lat = "-39.699164";
                        country_lon = "172.968302";

                        //Auckland
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 18, 0, 0),
                            Location = "Auckland Industry Connect",
                            RegistrationUrl = "http://www.meetup.com/IOT-Auckland/events/234601201/",
                            Latitude = -36.867738,
                            Longitude = 174.759779
                        });

                    }
                    if (Country == "Philippines")
                    {
                        // set the default country location

                        country_lat = "13.999143";
                        country_lon = "120.566613";

                        //Manila
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 18, 0, 0),
                            Location = "Microsoft Philippines",
                            RegistrationUrl = "https://www.eventbrite.com/e/apac-azure-iot-weekend-makati-tickets-28676085945",
                            Latitude = 14.555731,
                            Longitude = 121.020949
                        });
                    }
                    //if (Country == "Singapore")
                    //{
                    //    // set the default country location

                    //    country_lat = "3.254700";
                    //    country_lon = "107.874187";
                    //    //Singapore


                    //}
                    if (Country == "Sri Lanka")
                    {
                        // set the default country location

                        country_lat = "7.581798";
                        country_lon = "80.683103";

                        //Colombo
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 18, 0, 0),
                            Location = "Microsoft Sri Lanka",
                            RegistrationUrl = "http://www.meetup.com/APAC-Azure-IoT-Weekend-COLOMBO/",
                            Latitude = 6.918728,
                            Longitude = 79.850642
                        });
                    }
                    if (Country == "Vietnam")
                    {
                        // set the default country location

                        country_lat = "10.877407";
                        country_lon = "108.648612";

                        //HCMC
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 8, 30, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 11, 30, 0),
                            Location = "Microsoft Vietnam, Ho Chi Minh City",
                            RegistrationUrl = "https://www.eventbrite.com/e/apac-azure-iot-weekend-ho-chi-minh-tickets-28597419652",
                            Latitude = 10.776893,
                            Longitude = 106.698285
                        });
                    }
                    if (Country == "Thailand")
                    {
                        // set the default country location

                        country_lat = "15.258589";
                        country_lon = "100.771860";

                        //Khon Kaen,Thailand
                        events.Add(new Event()
                        {
                            StartDateTime = new DateTime(2016, 10, 29, 9, 0, 0),
                            EndDateTime = new DateTime(2016, 10, 29, 17, 30, 0),
                            Location = "Khon Kaen ICT Skill Development and Learning Center",
                            RegistrationUrl = "https://www.eventbrite.com/e/apac-azure-iot-weekend-khon-kaen-tickets-28547282691",
                            Latitude = 16.442879,
                            Longitude = 102.824210
                        });
                    }

                    MsgPanel.CssClass = string.Empty;
                    MsgPanel.CssClass = "alert alert-info";
                }

                else
                {
                    MsgPanel.CssClass = string.Empty;
                    MsgPanel.CssClass = "alert alert-warning";
                    lblMsg.Text = "Sorry but we can't find any event located in your country - " + Country + ". This event is only available at Australia, Indonesia, Korea, Malaysia, New Zealand, Philippines, Sri Lanka, Vietnam and Thailand. <br />You may use the below dropdown list to manually select your country.";
                }
            }
            catch { }

            EventRepeater.DataSource = events;
            EventRepeater.DataBind();

            PanelEvent.Visible = (events.Count == 0) ? false : true;
            PanelNoEvent.Visible = !PanelEvent.Visible;

            foreach (var ev in events)
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