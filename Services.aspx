<%@ Page Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Services.aspx.cs" Inherits="Services" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/TotalStyle.css" rel="stylesheet" type="text/css" />
    <link href="CSS/MainMaster.css" rel="stylesheet" type="text/css" />
    <link href="CSS/NewStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="box-orange" style="background-color: White">
        <h2 class="section">
            <table style="width: 100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center">
                        <b>
                            <asp:Label ID="LabelUserName" runat="server" Text="Services"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px" >
            <div class="msgbox ContentColor">
                <b>Business services</b></div>
            <div class="msgbox ContentColor">
                &nbsp;&nbsp; Four Seasons can assist you with business, entertainment or travel 
                arrangements through the resourceful and multilingual Concierge. In addition, 
                two offices, equipped with computers, are available for guests use around the 
                clock.<br />
                <br />
                <div class="msgbox ContentColor">
                    <b>&nbsp; Business amenities and services</b></div>
                <div class="msgbox">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Audiovisual equipment
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • 24-hour business services<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Computers
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Express check-in/check-out
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Secretarial service
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Translation and interpretation service
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Wired or wireless Internet access
                    <br />
                    <br />
                    <div class="msgbox ContentColor">
                        <b>&nbsp; Hours</b></div>
                    <div class="msgbox ContentColor">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Every day
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • 24 hours<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; • Help Supports
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

