<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="AdminInquiry.aspx.cs" Inherits="Admin_AdminInquiry" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelUserName" runat="server" Text="Inquiry"></asp:Label>
                        </b>
                    </td>
                </tr>
            </table>
        </h2>
        <div class="content BorderOrange" style="padding-top: 20px; padding-left: 10px">
            <asp:GridView ID="GridViewMessage" runat="server" AutoGenerateColumns="False" 
                Width="90%" OnRowDataBound="GridViewMessage_RowDataBound"
                OnRowDeleting="GridViewMessage_RowDeleting" 
                onrowcommand="GridViewMessage_RowCommand" DataKeyNames="MessageID">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <table style="width: 100%">
                                <tr align="left">
                                    <td style="width: 20%" align="left">
                                        Sender Name
                                    </td>
                                    <td style="width: 20%" align="left">
                                        Hotel Name
                                    </td>
                                    <td style="width: 50%" align="left">
                                        Message
                                    </td>
                                    <td style="width: 10%" align="left">
                                        Date
                                    </td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table style="width: 100%">
                                <tr align="left">
                                    <td style="width: 20%" align="left">
                                        <asp:LinkButton ID="LinkButtonSender" runat="server" Text='<%#bind("SenderName") %>' CommandArgument='<%# bind("MessageID") %>' CommandName="Read"></asp:LinkButton>
                                    </td>
                                    <td style="width: 20%" align="left">
                                        <asp:Label ID="LabelHotelName" runat="server" Text='<%#bind("HotelName") %>'></asp:Label>
                                    </td>
                                    <td style="width: 50%" align="left">
                                        <asp:Label ID="LabelMessage" runat="server" Text='<%#bind("Message") %>'></asp:Label>
                                    </td>
                                    <td style="width: 10%" align="left">
                                        <asp:Label ID="LabelDate" runat="server" Text='<%#bind("SendDate") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
