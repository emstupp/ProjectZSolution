<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectZ.PublicSite.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    Email&nbsp;&nbsp;
    <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
</p>
<p>
    Password&nbsp;
    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
</p>
    <p style="margin-left: 80px">
        <asp:Label ID="labSubmit" runat="server" ForeColor="Red"></asp:Label>
</p>
<p style="margin-left: 80px">
    <asp:Button ID="bSubmit" runat="server" OnClick="bSubmit_Click" Text="Submit" />
</p>
    <p>
        Don&#39;t have an account?
        <asp:HyperLink ID="hlSignUp" runat="server" ForeColor="Blue" NavigateUrl="~/CreateUser.aspx">Sign up</asp:HyperLink>
&nbsp;now!</p>

</asp:Content>
