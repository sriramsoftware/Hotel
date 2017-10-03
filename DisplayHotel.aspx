<%@ Page Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="DisplayHotel.aspx.cs" Inherits="DisplayHotel" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelCityName" runat="server" Text=""></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <center>
                <table style="width: 90%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <asp:GridView ID="GridViewHotel" runat="server" AutoGenerateColumns="False" ShowHeader="False"
                                OnRowDataBound="GridViewHotel_RowDataBound" DataKeyNames="HotelID" AllowPaging="True"
                                PageSize="1" OnPageIndexChanging="GridViewHotel_PageIndexChanging" OnRowCommand="GridViewHotel_RowCommand"
                                Width="100%" GridLines="None">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <table style="width: 100%" class="ContentColor">
                                                <tr>
                                                    <td align="center">
                                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#bind("HotelID") %>'
                                                            CommandName="Message">Send Message</asp:LinkButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <div class="box-blue" style="background-color: White">
                                                            <h2 class="section">
                                                                <b>
                                                                    <asp:Label ID="Label4" runat="server" Text='<%#bind("HotelName") %>'></asp:Label></b>
                                                            </h2>
                                                        </div>
                                                        <div class="content BorderBlue" style="padding-top: 10px; padding-left: 20px">
                                                            <table style="width: 100%">
                                                                <tr>
                                                                    <td style="width: 30%" valign="top" align="left">
                                                                        <asp:Image ID="ImageHotel" runat="server" ImageUrl='<%#bind("ImageUrl") %>' Width="200px"
                                                                            Height="200px" />
                                                                    </td>
                                                                    <td style="width: 70%" valign="top" align="left">
                                                                        <asp:Label ID="LabelDesc" runat="server" Text='<%#bind("HotelDiscription") %>'></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <div class="box-blue" style="background-color: White">
                                                            <h2 class="section">
                                                                <b>Address</b>
                                                            </h2>
                                                        </div>
                                                        <div class="content BorderBlue" style="padding-top: 10px; padding-left: 20px">
                                                            <asp:Label ID="LabelAddress" runat="server" Text='<%#bind("Address") %>'></asp:Label>
                                                            <br />
                                                            <asp:Label ID="LabelPhone" runat="server" Text='<%#bind("Phone") %>'></asp:Label>
                                                            <br />
                                                            <asp:Label ID="LabelEmail" runat="server" Text='<%#bind("Email") %>'></asp:Label>
                                                            <br />
                                                            <asp:Label ID="LabelState" runat="server" Text='<%#bind("State") %>'></asp:Label>
                                                            <br />
                                                            <asp:Label ID="LabelCity" runat="server" Text='<%#bind("CityName") %>'></asp:Label>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <div class="box-blue" style="background-color: White">
                                                            <h2 class="section">
                                                                <b>Rooms</b>
                                                            </h2>
                                                        </div>
                                                        <div class="content BorderBlue" style="padding-top: 10px; padding-left: 20px">
                                                            <asp:GridView ID="GridViewRooms" runat="server" AutoGenerateColumns="false" ShowFooter="false"
                                                                ShowHeader="false" Width="100%" GridLines="None">
                                                                <Columns>
                                                                    <asp:TemplateField>
                                                                        <ItemTemplate>
                                                                            <table style="width: 100%">
                                                                                <tr>
                                                                                    <td>
                                                                                        <strong>Room Type:</strong>
                                                                                        <asp:Label ID="LabelRoomType" runat="server" Text='<%#bind("RoomTypeName") %>'></asp:Label>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <strong>No Of Rooms:</strong>
                                                                                        <asp:Label ID="Label1" runat="server" Text='<%#bind("NoOfRoom") %>'></asp:Label>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <strong>Price:</strong>
                                                                                        <asp:Label ID="Label2" runat="server" Text='<%#bind("RoomPrice") %>'></asp:Label>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                            </asp:GridView>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </div>
</asp:Content>
