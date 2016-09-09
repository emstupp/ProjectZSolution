<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BuildSchedule.aspx.cs" Inherits="ProjectZ.PublicSite.BuildSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 433px;
        }
        .auto-style10 {
            width: 359px;
        }
        .auto-style11 {
            width: 84%;
        }
        .auto-style14 {
            width: 960px;
            height: 124px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table class="auto-style14">
        <tr>
            <td class="auto-style10">
                <br />
                Department Abbreviation:
                <asp:TextBox ID="tbDepartment" runat="server" MaxLength="4"></asp:TextBox>
                <br />
                <br />
                Course Number:
                <asp:TextBox ID="tbCourseNum" runat="server" MaxLength="4"></asp:TextBox>
                <br />
                <br />
                Title:
                <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
                <br />
            </td>
            <td>Start Time: <asp:TextBox ID="tbStartTime" runat="server" TextMode="Time"></asp:TextBox>
                <br />
                <br />
                End Time: <asp:TextBox ID="tbEndTime" runat="server" TextMode="Time"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                <asp:Repeater ID="rCourses" runat="server">
   <HeaderTemplate>
       <table>
           <tr>
               <td>
                   <strong>Class</strong>
               </td>
               <td>
                   <strong>Days</strong>
               </td>
               <td>
                   <strong>Duration</strong>
               </td>
               <td>
                   <strong>Professor</strong>
               </td>
           </tr>

   </HeaderTemplate>

   <ItemTemplate>
       <tr>
           <td><%# Eval("Department") %> <%# Eval("SectionNum") %></td>
           <td><%# Eval("Days") %></td>
           <td><%# Eval("StartTime") %> <%# Eval("EndTime") %></td>
           <td><%# Eval("Professor") %></td>
           <td>
               <asp:Button ID="bDeleteCourse" runat="server" CommandArgument='<%# Eval("CourseID") %>' OnClick="bDeleteCourse_Click" Text="Delete" />
           </td>
       </tr>
   </ItemTemplate>
   <FooterTemplate>
       </table>
   </FooterTemplate>
</asp:Repeater>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                <br />
                Select days:<br />
                <asp:CheckBoxList ID="cbDays" runat="server" RepeatDirection="Vertical" RepeatLayout="Table">
                    <asp:ListItem Text="Monday" Value="M"></asp:ListItem>
                    <asp:ListItem Text="Tuesday" Value="T"></asp:ListItem>
                    <asp:ListItem Text="Wednesday" Value="W"></asp:ListItem>
                    <asp:ListItem Text="Thursday" Value="R"></asp:ListItem>
                    <asp:ListItem Text="Friday" Value="F"></asp:ListItem>
                    <asp:ListItem Text="Saturday" Value="S"></asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td>Professor (optional): <asp:TextBox ID="tbProfessor" runat="server"></asp:TextBox>
                <br />
                <br />
                # of credits: <asp:TextBox ID="tbCredits" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bAddCourse" runat="server" Text="Add to Schedule" OnClick="bAddCourse_Click" />
            </td>
        </tr>
    </table>
    
    <br />
    
    
</asp:Content>
