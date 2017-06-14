<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterEvent.aspx.cs" Inherits="APACWeek.EnterEvent" %>

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
<body>
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
                    Please enter the relevant details of the event in the boxes. 
                    <br />
                    Join the Cross-platform Dev Community event to learn with experienced developer form industry and community from APAC on how you can build, test, and monitor native iOS, Android and Windows apps with Xamarin.
                    <br />
                </div>
            </div>

            <form method="post" runat="server">
                Location:<br />
                <input type="text" runat="server" name="Location" id="location1" value="" /><br />
                Event Name:<br />
                <input type="text" runat="server" name="EventName" id="name1" value="" /><br />
                Event Date:<br />
                <input type="date" runat="server" name="EventDate" id="date1" value="" /><br />
                Time:<br />
                <input type="time" runat="server" name="EventStart" id="startTime1" value="0000" /> to
                <input type="time" runat="server" name="EventEnd" id="endTime1" value="1200"  /><br />
                Registration Url:<br />
                <input type="url" runat="server" name="EventUrl" id="url1" value="" /><br />
                <br /> 
                <asp:DropDownList runat="server" ID="dropDownList1">
                    <asp:ListItem Selected="True">Please Select</asp:ListItem>                            
                    <asp:ListItem>Australia</asp:ListItem>
                    <asp:ListItem>Indonesia</asp:ListItem>
                    <asp:ListItem>Malaysia</asp:ListItem>
                    <asp:ListItem>New Zealand</asp:ListItem>
                    <asp:ListItem>Singapore</asp:ListItem>
                    <asp:ListItem>Philippines</asp:ListItem>
                    <asp:ListItem>Thailand</asp:ListItem>
                    <asp:ListItem>Vietnam</asp:ListItem>
                </asp:DropDownList> <br /> 
                <br /> 
                <input type="submit" runat="server" value="Submit" name="submitForm" class="submit" onserverclick="submitButtonEvent"/>

            </form>

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
</body>
</html>
