<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectZ.PublicSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style6 {
        width: 56%;
    }
    .auto-style7 {
        width: 268px;
    }
        .auto-style10 {
            width: 256px;
        }
        .auto-style11 {
            width: 51%;
        }
        .auto-style12 {
            width: 164px;
        }
        .auto-style13 {
            width: 32%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Do something, already...</p>
<table class="auto-style13">
    <tr>
        <td class="auto-style12">
    <asp:Button ID="bLogin" runat="server" OnClick="bFindZstat_Click" PostBackUrl="~/Login.aspx" Text="Log In" />
        </td>
        <td>
    <asp:Button ID="bSignUp" runat="server" OnClick="bFindTstat_Click" PostBackUrl="~/CreateUser.aspx" Text="Sign Up!" BackColor="Aqua" />
        </td>
    </tr>
</table>
    <br />
<table class="auto-style11">
    <tr>
        <td class="auto-style10">
    <asp:Button ID="bFindZstat" runat="server" OnClick="bFindZstat_Click" PostBackUrl="~/ZStatistic.aspx" Text="Find Z-statistic..." />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
