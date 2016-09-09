<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateAssignment.aspx.cs" Inherits="ProjectZ.PublicSite.CreateAssignment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style8 {
            width: 459px;
        }
        .auto-style9 {
            width: 459px;
            height: 75px;
        }
        .auto-style10 {
            height: 75px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <table class="auto-style6">
            <tr>
                <td class="auto-style9">Name of assignment:&nbsp;
                    <asp:TextBox ID="tbHWName" runat="server"></asp:TextBox>
&nbsp;&nbsp;</td>
                <td class="auto-style10">Due Date:
                    <asp:TextBox ID="tbDueDate" runat="server"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <br />
                    What kind of assignment is it?<br />
                    <asp:RadioButtonList ID="rbHWType" runat="server">
                        <asp:ListItem Text="Homework" Value="Homework"></asp:ListItem>
                        <asp:ListItem Text="Essay" Value="Essay"></asp:ListItem>
                        <asp:ListItem Text="Presentation" Value="Project"></asp:ListItem>
                        <asp:ListItem Text="Project" Value="Project"></asp:ListItem>
                        <asp:ListItem Text="Exam" Value="Exam"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    What class is this for?<br />
                    <br />
                    <asp:DropDownList ID="ddlCourseList" runat="server" DataTextField="Title" DataValueField="CourseID"></asp:DropDownList>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="bAddAssignment" runat="server" Text="Add Assignment" OnClick="bAddAssignment_Click" />
    </asp:Content>
