<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="ProjectZ.PublicSite.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rUsers" runat="server" DataSourceID="(localdb)\v11.0">
    </asp:Repeater>
    </asp:Content>
