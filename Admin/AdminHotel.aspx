<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="AdminHotel.aspx.cs" Inherits="Admin_AdminHotel" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelUserName" runat="server" Text="Hotel"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <table style="width: 50%">
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
                <tr>
                    <td>
                        City Name
                    </td>
                    <td align="left">
                        <asp:DropDownList ID="DropDownListCity" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Hotel Name
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        Description
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxDesc" runat="server" TextMode="MultiLine" Width="200px" Height="100px"
                            Columns="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        Address
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxAdd" runat="server" TextMode="MultiLine" Width="200px" Height="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        State
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxState" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        Phone
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxPhone" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        Email
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        Image
                    </td>
                    <td align="left">
                        <asp:FileUpload ID="FileUploadImage" runat="server" />
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
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                </tr>
            </table>
            <table style="width: 90%">
                <tr>
                    <td>
                        <asp:GridView ID="GridViewHotel" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridViewHotel_RowCancelingEdit"
                            OnRowDeleting="GridViewHotel_RowDeleting" Width="50%" 
                            DataKeyNames="HotelID" onrowcommand="GridViewHotel_RowCommand">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width: 100%">
                                            <tr>
                                                <td style="width: 50%" align="left">
                                                    <asp:Label ID="LabelName" runat="server" Text='<%#bind("HotelName") %>'></asp:Label>
                                                </td>
                                                <td style="width: 50%" align="left">
                                                    <asp:LinkButton ID="LinkButtonEdit" runat="server" CommandName="EditHotel" CommandArgument='<%# bind("HotelID") %>'>Edit</asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
