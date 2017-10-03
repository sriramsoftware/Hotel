<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true"
    CodeFile="AdminCity.aspx.cs" Inherits="Admin_AdminCity" Title="Untitled Page" %>

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
                            <asp:Label ID="LabelUserName" runat="server" Text="City"></asp:Label>
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
                        City Name
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxCityName" runat="server" Width="150"></asp:TextBox>
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
            <table style="width:70%">
                <tr>
                    <td>
                        <asp:GridView ID="GridViewCity" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="CityID" Width="100%" 
                            onrowcancelingedit="GridViewCity_RowCancelingEdit" 
                            onrowdeleting="GridViewCity_RowDeleting" onrowediting="GridViewCity_RowEditing" 
                            onrowupdating="GridViewCity_RowUpdating">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <table style="width:70%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="LabelCity" runat="server" Text='<%#bind("CityName") %>' ></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                         <table style="width:70%">
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBoxCity" runat="server" Text='<%#bind("CityName") %>'></asp:TextBox>
                                                    
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
            </table>
            <%--end Page Content--%>
        </div>
    </div>
</asp:Content>
