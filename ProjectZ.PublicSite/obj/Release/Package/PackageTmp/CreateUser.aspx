<%@ Page Title="CreateUser" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="ProjectZ.PublicSite.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
<p>
    First Name&nbsp;&nbsp;
    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbFirstName" ErrorMessage="This field is required." ValidationGroup="vgLogin"></asp:RequiredFieldValidator>
</p>
<p>
    Last Name&nbsp;
    <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLastName" ErrorMessage="This field is required." ValidationGroup="vgLogin"></asp:RequiredFieldValidator>
</p>
<p>
    Email Addresss&nbsp;&nbsp;
    <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" ErrorMessage="This field is required." ValidationGroup="vgLogin"></asp:RequiredFieldValidator>
</p>
New Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbPassword" ErrorMessage="This field is required." ValidationGroup="vgLogin"></asp:RequiredFieldValidator>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<p style="margin-left: 80px">
    <asp:Button ID="bSubmit" runat="server" OnClick="bSubmit_Click" Text="Submit" />
</p>
</asp:Content>
