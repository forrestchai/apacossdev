<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="APACWeek.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>APAC Cross-Platform Dev Community 2017</title>

    <%-- css --%>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .subText {
            opacity: .7;
        }

        .form-group {
            margin-bottom: 0;
        }
    </style>

    <%-- js --%>
    <script src="scripts/jquery-3.1.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    
</head>
<body onload="GetMap();">
    <form id="form1" runat="server">
        <div style="background-color: #00198D;">
            <img class="center-block img-responsive" src="images/banner-lg.png" />
        </div>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 page-header">
                    <h2>Welcome to APAC Cross-Platform Dev Community</h2>
                </div>
            </div>

            <div class="row" style="font-size: 23px; font-weight: 200;">
                <div class="col-xs-12">
                    If you are a .NET developer who’s ready to dive into the mobile world, Xamarin is the tool for you! <br />
                    Xamarin is an open source framework that allow developers to create mobile applications for cross-platform written in a single language.
                    <br />
                    Join the Cross-platform Dev Community event to learn with experienced developer form industry and community from APAC on how you can build, test, and monitor native iOS, Android and Windows apps with Xamarin.
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
                                <asp:ListItem>Malaysia</asp:ListItem>
                                <asp:ListItem>New Zealand</asp:ListItem>
                                <asp:ListItem>Singapore</asp:ListItem>
                                <asp:ListItem>Philippines</asp:ListItem>
                                <asp:ListItem>Thailand</asp:ListItem>
                                <asp:ListItem>Vietnam</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <br />

                    <asp:Panel ID="PanelEvent" runat="server">
                        <h3 style="font-weight: 400;">Upcoming Event(s) details</h3>
                        <asp:Repeater ID="UpcomingEventRepeater" runat="server">
                            <ItemTemplate>
                                <div class="well well-lg form-horizontal">
                                    <%-- location --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Location:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("Location")%></h4>
                                        </div>
                                    </div>
                                    <%-- Event Name --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Event Name:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("EventName")%></h4>
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
                        <h3 style="font-weight: 400;">Past Event(s) details</h3>
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
                                    <%-- Event Name --%>
                                    <div class="form-group">
                                        <h4 class="col-sm-3">Event Name:</h4>
                                        <div class="col-sm-9">
                                            <h4 class="subText"><%#Eval("EventName")%></h4>
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
                        <h3 class="subText">Sorry, we can't find any event located in your country. Please come back again.</h3>
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
