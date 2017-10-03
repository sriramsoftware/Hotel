<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="AdminEditHotel.aspx.cs" Inherits="Admin_AdminEditHotel" Title="Untitled Page" %>

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
                    <td colspan="2" align="center">
                        <asp:Image ID="ImageHotel" runat="server" Width="100px" Height="100px" />
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
                        <asp:Button ID="ButtonAdd" runat="server" Text="Edit" Width="100" 
                            onclick="ButtonAdd_Click"  />&nbsp;&nbsp;
                         <asp:Button ID="ButtonCancle" runat="server" Text="Cancle" Width="100" 
                            onclick="ButtonCancle_Click"  />&nbsp;&nbsp;
                          <asp:Button ID="ButtonBack" runat="server" Text="Back" Width="100" 
                            onclick="ButtonBack_Click"  />&nbsp;&nbsp;
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
        </div>
    </div>
</asp:Content>
