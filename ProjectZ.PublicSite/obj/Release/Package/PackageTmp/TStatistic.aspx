<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TStatistic.aspx.cs" Inherits="ProjectZ.PublicSite.TStatistic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style23 {
            width: 316px;
            height: 77px;
        }
        .auto-style24 {
            width: 453px;
            height: 77px;
        }
        .auto-style21 {
            width: 316px;
            height: 63px;
        }
        .auto-style22 {
            width: 453px;
            height: 63px;
        }
        .auto-style25 {
            width: 52%;
            height: 135px;
        }
        .auto-style31 {
            height: 45px;
        }
        .auto-style33 {
            height: 45px;
            width: 302px;
        }
        .auto-style34 {
            width: 302px;
        }
        .auto-style35 {
            width: 99%;
            height: 132px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <table class="auto-style25">
        <tr>
            <td class="auto-style23">Choose your alpha level:</td>
            <td class="auto-style24">
    <asp:RadioButtonList ID="rbAlphaLevel" runat="server" 
                RepeatDirection="Vertical" RepeatLayout="Table">
                <asp:ListItem Text="0.10 (90% confidence)" Value="0.10"></asp:ListItem>
                <asp:ListItem Text="0.05 (95% confidence)" Value="0.05"></asp:ListItem>
                <asp:ListItem Text="0.01 (99% confidence)" Value="0.01"></asp:ListItem>
                
            </asp:RadioButtonList>
            </td>
        </tr>

        <tr>
            <td class="auto-style21">Run a one-tailed or two-tailed test?<br />
                <br />
                <br />
                Enter the population mean:</td>
            <td class="auto-style22">
    <asp:RadioButtonList ID="rbTwoTailed" runat="server" 
                RepeatDirection="Vertical" RepeatLayout="Table">
                <asp:ListItem Text="One-Tailed" Value="False"></asp:ListItem>
                <asp:ListItem Text="Two-Tailed" Value="True"></asp:ListItem>
                
            </asp:RadioButtonList>
                <br />
                <asp:TextBox ID="tbPopMean" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>


        <tr>
            <td class="auto-style23">Enter statistics about both samples?
                <br />
        <asp:Button ID="bAutoSample" runat="server" OnClick="bAutoSample_Click" Text="Auto" Width="105px" />
            </td>
            <td class="auto-style24">
                                Enter both samples&#39; observations manually?<br />
        <asp:Button ID="bManualSample" runat="server" Text="Manual" Width="108px"/>
            </td>
        </tr>
    </table>


        <br />


        <br />
    <asp:Panel ID="panAutoTSample" runat="server" Width="628px">
    <table class="auto-style35">
        
        <tr>

            
            <td class="auto-style34">
                                Sample Size 1:&nbsp;<asp:TextBox ID="tbSampleSizeA1" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                                </td>
            <td>
                                Sample Size 2:&nbsp;
                                <asp:TextBox ID="tbSampleSizeA2" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                                </td>
        </tr>
        <tr>
            <td class="auto-style33">
                                Standard Deviation 1:&nbsp;&nbsp;<asp:TextBox ID="tbStdDev1" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
            <td class="auto-style31">
                                Standard Deviation 2:&nbsp;<asp:TextBox ID="tbStdDev2" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
        </tr>
        <tr>
            <td class="auto-style34">
                                Mean 1:&nbsp; <asp:TextBox ID="tbMean1" runat="server" TextMode="Number" Width="125px"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td>
                                Mean 2:&nbsp; <asp:TextBox ID="tbMean2" runat="server" TextMode="Number" Width="125px"></asp:TextBox>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>

        </tr>
        
    </table>
    </asp:Panel>
    <br />
    <br />
</asp:Content>
