<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CareerList.aspx.cs" Inherits="ProjectZ.PublicSite.CareerList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Label ID="labSearchCareers" runat="server" Text="Search Careers:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
    </p>
<p>
        Enter Zip Code:&nbsp; &nbsp;
        <asp:TextBox ID="tbZipCode" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 80px">
        <asp:Button ID="bSearch" runat="server" OnClick="bSearch_Click" Text="Search" />
    </p>
        &nbsp;<asp:Repeater ID="rCareerList" runat="server">
            <HeaderTemplate>
                <h2>Careers</h2>
                <br />
            </HeaderTemplate>
            <ItemTemplate>
                <%# Eval("cid") %>
                <br />
                <%# Eval("label") %>
                <br />
                <%# Eval("desc") %>
                <br />
                <input type="button" onclick='<%# "GetCareerDetails(\"" + Eval("cid") + "\", \"lCareerDetails" + Eval("cid") + "\");" %>' value="Get Details" />
                <br />
                <label id='<%# "lCareerDetails" + Eval("cid") %>'></label>
                <hr />
            </ItemTemplate>
        </asp:Repeater>

        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js" type="text/javascript"></script>
        <script type="text/javascript">
function GetCareerDetails(cid, outputLabel) {
var jqxhr = $.ajax({
method: "GET",
url: "http://www.benobe.com/iapi/career/" + cid + "/<%= tbZipCode.Text %>",
dataType: "json",
headers: { "x-access-token": "<%= BenobeAPIKey %>" }
})
.done(function (data) {
    if (data.status === 1) {
        // DO SOMETHING WITH THE RETURN DATA HERE
        document.getElementById(outputLabel).innerHTML += "<strong>COMPENSATION minavgmax</strong><br />";
        document.getElementById(outputLabel).innerHTML += data.career.COMPENSATION.minavgmax + "<br />";
        document.getElementById(outputLabel).innerHTML += "<br />";

        document.getElementById(outputLabel).innerHTML += "<strong>INTERESTS</strong><br />";
        for (i = 0; i < data.career.INTERESTS.items.length; i++) {
            document.getElementById(outputLabel).innerHTML += data.career.INTERESTS.items[i].numvar + " - " + data.career.INTERESTS.items[i].elem + "<br />";
        }
        document.getElementById(outputLabel).innerHTML += "<br />";

        document.getElementById(outputLabel).innerHTML += "<strong>SKILLS</strong><br />";
        for (i = 0; i < data.career.SKILLS.items.length; i++) {
            document.getElementById(outputLabel).innerHTML += data.career.SKILLS.items[i].numvar + " - " + data.career.SKILLS.items[i].elem + "<br />";
        }
        document.getElementById(outputLabel).innerHTML += "<br />";
    } else {
        // DO SOMETHING WITH THE ERROR HERE
        alert('Error');
    }
})
.fail(function () {
    // DO SOMETHING IF THE API CALL FAILED
    alert('Error - API CALL FAILED');
});
}
        </script>
</asp:Content>
