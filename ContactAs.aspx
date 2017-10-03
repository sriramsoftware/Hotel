<%@ Page Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="ContactAs.aspx.cs" Inherits="ContactAs" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="CSS/MainMaster.css" rel="stylesheet" type="text/css" />
    <link href="CSS/TotalStyle.css" rel="stylesheet" type="text/css" />
    <link href="CSS/NewStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="box-orange" style="background-color: White">
        <h2 class="section">
            <table style="width: 100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center">
                        <b>
                            <asp:Label ID="LabelUserName" runat="server" Text="Contact Us"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <table style="width: 100%" cellpadding="0" cellspacing="0" class="ContentColor">
                <tr>
                    <td align="center">
                        <p class="MsoNormal">
                            Hotel Management<b> Pvt. Ltd</b><br />
                            <b>Address:&quot;Banthiya Colony&quot; Rampura; Kota Rajasthan</b><br />
                            <b>Telephone:</b> +91 9636127313 <b>(IST 9:30 Hrs - 20:00 Hrs)</b><br />
                            <b>Fax</b>: +91 53 4331 7780</p>
                        <p class="MsoNormal">
                            <b>Email: banthiya.jain13@gmail.com</b><br />
                            <br />
                            <b>24 Hr Helpline:</b><br />
                            <b>For Kota:</b> +91-9790122864 (SHRADDHA)<br />
                            <b>For Outside Kota:</b> +91-9600578341(KARTIK)<br />
                            <br />
                            <br />
                            <strong>Chennai Office<br />
                            P-207</strong>, Second Floor, Abode Valley, Potheri<br />
                            Chennai - 603203<br />
                            <b>Telephone:</b> +91 7601877333<br />
                            Email: shraddhak000@gmail.com<br />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
