<%@ Page Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true"
    CodeFile="SendInquiry.aspx.cs" Inherits="SendInquiry" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="CSS/TotalStyle.css" rel="stylesheet" type="text/css" />
    <link href="CSS/MainMaster.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="box-orange" style="background-color: White">
        <h2 class="section">
            <table style="width: 100%" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center">
                        <b>
                            <asp:Label ID="LabelUserName" runat="server" Text="Send Message"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <center>
                <table style="width: 90%">
                    <tr>
                        <td colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Hotel Name
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBoxHotelName" runat="server" Width="300px" Enabled="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Your Name
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBoxName" runat="server" Width="300px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ErrorMessage="Must be add" ControlToValidate="TextBoxName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Email
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBoxEmail" runat="server" Width="300px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ErrorMessage="Email not valid" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBoxEmail"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Phone
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBoxPhone" runat="server" Width="300px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ErrorMessage="Fill The Number" ControlToValidate="TextBoxPhone"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            Your Message
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TextBoxMessage" runat="server" TextMode="MultiLine" Width="300px" Height="200px"
                                Columns="10"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="ButtonSend" runat="server" Text="Send" Width="100" 
                                onclick="ButtonSend_Click" />
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </div>
</asp:Content>
