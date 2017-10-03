<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="RoomType.aspx.cs" Inherits="RoomType" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelUserName" runat="server" Text="Room Type"></asp:Label>
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
                    <td>
                        <asp:TextBox ID="TextBoxRoomType" runat="server" Width="150"></asp:TextBox>
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
                        <asp:GridView ID="GridViewRoomType" runat="server" AutoGenerateColumns="False" DataKeyNames="RoomTypeID"
                            Width="100%" onrowcancelingedit="GridViewRoomType_RowCancelingEdit" 
                            onrowediting="GridViewRoomType_RowEditing" 
                            onrowupdating="GridViewRoomType_RowUpdating" 
                            onrowdeleting="GridViewRoomType_RowDeleting" >
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width: 70%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="LabelCity" runat="server" Text='<%#bind("RoomTypeName") %>'></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <table style="width: 70%">
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBoxRoomType" runat="server" Text='<%#bind("RoomTypeName") %>'></asp:TextBox>
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
