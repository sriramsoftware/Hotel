<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="HotelRoom.aspx.cs" Inherits="Admin_HotelRoom" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../CSS/MainMaster.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/TotalStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="box-orange" style="background-color: White">
        <h2 class="section">
            <table style="width: 100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center">
                        <b>
                            <asp:Label ID="LabelUserName" runat="server" Text="Hotel Room"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <%-- this content--%>
            <table style="width: 50%">
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
                <tr>
                    <td>
                        Room Type
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="DropDownListRoomType" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hotel
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="DropDownListHotel" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        No Of Rooms.
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxNoOFRooms" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Price/Rooms.
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="ButtonAdd" runat="server" Text="Add" Width="100" OnClick="ButtonAdd_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridViewHotelRoom" runat="server" AutoGenerateColumns="False" DataKeyNames="HotelRoomID"
                            Width="100%" onrowcancelingedit="GridViewHotelRoom_RowCancelingEdit" 
                            onrowdeleting="GridViewHotelRoom_RowDeleting" 
                            onrowediting="GridViewHotelRoom_RowEditing" 
                            onrowupdating="GridViewHotelRoom_RowUpdating">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width:30%" align="left">
                                                    <asp:Label ID="LabelCity" runat="server" Text='<%#bind("HotelName") %>'></asp:Label>
                                                </td>
                                                <td style="width:30%" align="left">
                                                    <asp:Label ID="Label1" runat="server" Text='<%#bind("RoomTypeName") %>'></asp:Label>
                                                </td>
                                                <td style="width:20%" align="left">
                                                    <asp:Label ID="Label2" runat="server" Text='<%#bind("NoOfRoom") %>'></asp:Label>
                                                </td>
                                                <td style="width:20%" align="left">
                                                    <asp:Label ID="Label3" runat="server" Text='<%#bind("RoomPrice") %>'></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width:30%" align="left">
                                                    <asp:Label ID="LabelCity" runat="server" Text='<%#bind("HotelName") %>'></asp:Label>
                                                </td>
                                                <td style="width:30%" align="left">
                                                    <asp:Label ID="Label1" runat="server" Text='<%#bind("RoomTypeName") %>'></asp:Label>
                                                </td>
                                                <td style="width:20%" align="left">
                                                    <asp:TextBox ID="TextBoxNoOfRoom" runat="server" Text='<%#bind("NoOfRoom") %>' Width="50"></asp:TextBox>
                                                </td>
                                                <td style="width:20%" align="left">
                                                    <asp:TextBox ID="TextBoxPrice" runat="server" Text='<%#bind("RoomPrice") %>'  Width="50"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
