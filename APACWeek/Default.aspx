<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="APACWeek.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>APAC Azure IoT Weekend 2016</title>

    <%-- css --%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .subText {
            opacity: .7;
        }

        .form-group {
            margin-bottom: 0;
        }
        .auto-style1 {
            font-size: large;
        }
    </style>

    <%-- js --%>
    <script src="scripts/jquery-1.9.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-85671523-1', 'auto');
        ga('send', 'pageview');

    </script>
</head>
<body onload="GetMap();">
    <form id="form1" runat="server">
        <div style="background-color: #00198D;">
            <img class="center-block img-responsive" src="images/banner-lg.png" />
        </div>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 page-header">
                    <h2>Welcome to APAC IoT Weekend 2016</h2>
                </div>
            </div>

            <div class="row" style="font-size: 23px; font-weight: 200;">
                <div class="col-xs-12">
                    <p class="MsoNormal">
                        <span>Disruptive Technologies in today’s connected world are transforming traditional business processes, industries, and life. We are living in a world of “smart products” and new “intelligent business services”. Advanced technological capabilities like the Internet of Things, cloud, mobile, social, and big data require organizations to transform their business processes to enable connected business networks.<o:p></o:p></span>
                    </p>
                    <p class="MsoNormal">
                        <o:p>&nbsp;</o:p>
                    </p>
                    <p class="MsoNormal">
                        <b><span>Transform Business &amp; Uncover New Opportunities with Internet of Things<o:p></o:p></span></b>
                    </p>
                    <p class="MsoNormal">
                        <b><span>
                            <o:p>&nbsp;</o:p>
                        </span></b>
                    </p>
                    <p class="MsoNormal">
                        <span>Meet the IoT Community on Oct 29<sup>th</sup> 2016. Learn and hands-on to tap into the power of IoT: connect up your devices, harness untapped data, turn them into insights and business value. Microsoft is honored to gain active contribution of various IoT community for the events at 10 cities on the same day and would like to acknowledge all community leads contribution in making this event a success!<o:p></o:p></span>
                    </p>
                    <br />
                    <div>
                        <button type="button" class="btn btn-info" style="cursor: pointer;" data-toggle="collapse" data-target="#speakerList">
                            Meet our Keynote Speakers and Influencers&nbsp;&nbsp;<span class="caret"></span>
                        </button>
                        <div class="collapse" id="speakerList">
                            <div class="list-group col-sm-12">
                                <asp:Repeater ID="SpeakerRepeater" runat="server">
                                    <ItemTemplate>
                                        <div class="list-group-item col-md-6">
                                            <div class="media" style="margin: 12px;">
                                                <div class="media-left">
                                                    <img class="media-object img-circle" style="width: 100px; margin-right: 12px;" src="<%#Eval("PhotoPath")%>">
                                                </div>
                                                <div class="media-body">
                                                    <h4 class="media-heading"><%#Eval("Name")%>, <%#Eval("Country")%></h4>
                                                    <h5><div style="height:225px"> <%#Eval("Profile")%></div></h5>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                    <p class="MsoNormal">
                        <br />  
                    </p>
                    <p class="MsoNormal">
                        <o:p>Here&#39;s the overview on the agenda</o:p>
                       
                        <center>
                            <asp:Image ID="agenda" runat="server" ImageUrl="~/images/agenda.PNG" AlternateText="Agenda" />
                            <br /><em>Remark: The actual time will depend on the local influencer.</em>

                        </center>
                    </p>
                    

                    <p class="MsoNormal">
                        <o:p><span><strong>#APACAzureIoTWeekend</strong></span></o:p>
                    </p>
                </div>
            </div>

            <br />

            <div class="row">
                <div class="col-md-12 jumbotron">

                    <asp:Panel ID="MsgPanel" class="alert alert-info" runat="server">
                        <p class="small">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        </p>
                    </asp:Panel>
                    <hr />


                    <h4>If you think that we detected your location incorrectly, you may select your location based on the list here :&nbsp;</h4>
                    <div class="row">
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" CssClass="form-control">
                                <asp:ListItem Selected="True">Please Select</asp:ListItem>
                                <asp:ListItem>Australia</asp:ListItem>
                                <asp:ListItem>Indonesia</asp:ListItem>
                                <asp:ListItem>Korea</asp:ListItem>
                                <asp:ListItem>Malaysia</asp:ListItem>
                                <asp:ListItem>New Zealand</asp:ListItem>
                                <asp:ListItem>Philippines</asp:ListItem>
                                <asp:ListItem>Sri Lanka</asp:ListItem>
                                <asp:ListItem>Vietnam</asp:ListItem>
                                <asp:ListItem>Thailand</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <br />

                    <asp:Panel ID="PanelEvent" runat="server">
                        <h3 style="font-weight: 400;">Event(s) details</h3>
                        <asp:Repeater ID="EventRepeater" runat="server">
                            <ItemTemplate>
                                <div class="well well-lg form-horizontal">
                                    <%-- location --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Location:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("Location")%></h4>
                                        </div>
                                    </div>

                                    <%-- date --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Date:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("StartDateTime","{0:d MMM yyyy}")%></h4>
                                        </div>
                                    </div>

                                    <%-- time --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Time:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("StartDateTime","{0:h:mm tt}")%> to <%#Eval("EndDateTime","{0:h:mm tt}")%></h4>
                                        </div>
                                    </div>

                                    <%-- register url --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Registration URL:</h4>
                                        <div class="col-sm-9">
                                            <h4><a href="<%#Eval("RegistrationUrl")%>"><%#Eval("RegistrationUrl")%></a></h4>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>

                        <%-- map --%>
                        <div>
                            <h4 class="col-sm-12">Location Map:</h4>
                            <div id="myMap" class="col-sm-12" style="height: 400px;"></div>

                            <asp:Literal ID="Literal1" runat="server">
                            </asp:Literal>
                        </div>
                    </asp:Panel>

                    <asp:Panel ID="PanelNoEvent" runat="server">
                        <h3 class="subText">Sorry, we can't find any event located in your country.</h3>
                    </asp:Panel>

                </div>
            </div>

            <div class="row">
                <div class="col-lg-2">
                    &nbsp;
                </div>
                <div class="col-lg-10">
                    <ul class="list-inline pull-right">

                        <li class="liStyle">
                            <p class="MsoNormal">
                                <a href="http://go.microsoft.com/?linkid=2028351"><span>Contact Us</span></a><span> | </span><a href="http://www.microsoft.com/en-us/legal/intellectualproperty/copyright/default.aspx"><span>Terms of Use</span></a><span> | </span><a href="http://www.microsoft.com/library/toolbar/3.0/trademarks/en-us.mspx"><span>Trademark</span></a><span> | </span><a href="http://go.microsoft.com/fwlink/?LinkId=521839"><span>Privacy Statement</span></a><span> | © 2016 Microsoft Corporation</span><o:p></o:p>
                            </p>
                        </li>
                    </ul>
                </div>
            </div>

        </div>
    </form>

</body>
</html>
