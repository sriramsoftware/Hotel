<%@ Page Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="ShowAllHotel.aspx.cs" Inherits="ShowAllHotel" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelUserName" runat="server" Text="All Hotel"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <center>
                <table style="width: 90%" class="ContentColor">
                    <tr>
                        <td>
                            <asp:DataList ID="DataListHotel" runat="server" Width="100%" 
                                RepeatDirection="Horizontal" RepeatColumns="3" 
                                onitemcommand="DataListHotel_ItemCommand" 
                                onselectedindexchanged="DataListHotel_SelectedIndexChanged">
                                <ItemTemplate>
                                    <table style="width: 100%">
                                        <tr>
                                            <td>
                                                <asp:Image ID="Image1" runat="server" Width="150px" Height="150px" ImageUrl='<% #bind("ImageUrl") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:LinkButton ID="LinkButtonHotelName" runat="server" Text='<%#bind("HotelName") %>' CommandArgument='<%# bind("CityID") %>' CommandName="Hotel" ></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </div>
</asp:Content>
