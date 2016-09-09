<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="ProjectZ.PublicSite.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style6 {
        width: 56%;
    }
    .auto-style7 {
        width: 328px;
    }
    .auto-style8 {
        width: 181px;
    }
    .auto-style9 {
        width: 40%;
    }
    .auto-style10 {
        width: 296px;
        height: 30px;
    }
    .auto-style11 {
        height: 30px;
            width: 169px;
        }
        .auto-style12 {
            width: 296px;
        }
        .auto-style13 {
            width: 164px;
            height: 39px;
        }
        .auto-style14 {
            height: 39px;
        }
        .auto-style15 {
            width: 40%;
            height: 23px;
            margin-bottom: 0px;
        }
        .auto-style16 {
            width: 169px;
        }
        .auto-style17 {
            width: 544px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<table class="auto-style17">
    <tr>
        <td class="auto-style12">First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
            </td>
        <td class="auto-style16">
        <asp:Label ID="labFirstName" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        <td class="auto-style11">
        <asp:Label ID="labLastName" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style12">Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        <td class="auto-style16">
        <asp:Label ID="labEmail" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
    <p style="margin-left: 120px">
&nbsp;&nbsp;
        <asp:Button ID="bUpdate" runat="server" OnClick="bUpdate_Click" Text="Update" Width="56px" />
    </p>
    <table class="auto-style15">
        <tr>
            <td class="auto-style13">
        <asp:HyperLink ID="hlChangePW" runat="server" NavigateUrl="~/UpdatePassword.aspx">Change Password...</asp:HyperLink>
            </td>
            <td class="auto-style14">
        <asp:HyperLink ID="hlDeleteUser" runat="server" ForeColor="#CC0000">Delete Account</asp:HyperLink>
            </td>
        </tr>
</table>
<p>
        &nbsp;</p>
</asp:Content>
