<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="ProjectZ.PublicSite.UpdatePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style6 {
        width: 43%;
    }
    .auto-style7 {
        width: 503px;
    }
    .auto-style8 {
        width: 416px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:HyperLink ID="hlGoBack" runat="server" ForeColor="#FF6600" NavigateUrl="~/UpdateUser.aspx">Back</asp:HyperLink>
</p>
<table class="auto-style6">
    <tr>
        <td class="auto-style7">Old Password:&nbsp;&nbsp;</td>
        <td class="auto-style8">
        <asp:TextBox ID="tbOldPass" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">New Password:&nbsp;&nbsp;&nbsp;</td>
        <td class="auto-style8"><asp:TextBox ID="tbNewPass" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Confirm
        New Password:&nbsp;&nbsp;&nbsp;</td>
        <td class="auto-style8"><asp:TextBox ID="tbNewPassConfirm" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
</table>
<p>
        &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;</p>
<p>
        &nbsp;</p>
<p>
    &nbsp;</p>
<p style="margin-left: 120px">
&nbsp;&nbsp;
        <asp:Button ID="bUpdate" runat="server" OnClick="bUpdate_Click" Text="Update" Width="56px" />
</p>
</asp:Content>
