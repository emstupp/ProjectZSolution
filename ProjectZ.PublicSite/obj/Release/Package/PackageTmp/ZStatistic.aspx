<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ZStatistic.aspx.cs" Inherits="ProjectZ.PublicSite.ZStatistic"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 74%;
            height: 259px;
        }
        .auto-style8 {
            width: 226px;
        }
        .auto-style12 {
            width: 387px;
            height: 175px;
        }
        .auto-style15 {
            height: 60px;
            width: 292px;
        }
        .auto-style16 {
            width: 292px;
        }
        .auto-style19 {
            margin-left: 160px;
        }
        .auto-style27 {
            width: 554px;
        }
        .auto-style28 {
            width: 360px;
            height: 23px;
        }
        .auto-style29 {
            width: 554px;
            height: 23px;
        }
        .auto-style30 {
            width: 360px;
        }
        .auto-style32 {
        width: 423px;
        height: 158px;
    }
        .auto-style34 {
            width: 76%;
            height: 234px;
        }
        .auto-style35 {
            width: 56%;
            height: 71px;
        }
        .auto-style36 {
            width: 79%;
            height: 71px;
        }
        .auto-style37 {
            width: 100%;
            height: 354px;
        }
        .auto-style39 {
            width: 198px;
        }
        .auto-style42 {
            width: 432px;
        }
        .auto-style43 {
            width: 79%;
            height: 137px;
        }
        .auto-style45 {
            width: 191px;
        }
        .auto-style46 {
            width: 213px;
            height: 129px;
        }
        .auto-style47 {
            height: 129px;
        }
        .auto-style48 {
            width: 386px;
        }
    .auto-style49 {
        width: 198px;
        height: 202px;
    }
    .auto-style50 {
        width: 191px;
        height: 202px;
    }
    .auto-style51 {
        height: 202px;
    }
    .auto-style53 {
        height: 60px;
        width: 255px;
    }
    .auto-style54 {
        width: 255px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <asp:Panel runat="server" ID="panMainMenu" Height="139px" Width="633px">
        <table class="auto-style43">
            <tr>
                <td class="auto-style48">Choose your alpha level:</td>
                <td class="auto-style42">
                    <asp:RadioButtonList ID="rbAlphaLevel" runat="server"
                        RepeatDirection="Vertical" RepeatLayout="Table">
                        <asp:ListItem Text="0.10 (90% confidence)" Value="0.10"></asp:ListItem>
                        <asp:ListItem Text="0.05 (95% confidence)" Value="0.05"></asp:ListItem>
                        <asp:ListItem Text="0.01 (99% confidence)" Value="0.01"></asp:ListItem>

                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style48">Run a one-tailed or two-tailed test?</td>
                <td class="auto-style42">
                    <asp:RadioButtonList ID="rbTwoTailed" runat="server"
                        RepeatDirection="Vertical" RepeatLayout="Table">
                        <asp:ListItem Text="One-Tailed" Value="False"></asp:ListItem>
                        <asp:ListItem Text="Two-Tailed" Value="True"></asp:ListItem>

                    </asp:RadioButtonList>
                </td>
                </asp:Panel>
            </tr>
        </table>
    
    <br />
    <table class="auto-style37">
        <tr>
            <td class="auto-style49">Population mean:<br />
                    <br />
                    Pop. Std. Dev:</td>
            <td class="auto-style50">
                    <asp:TextBox ID="tbPopMean" runat="server" Width="128px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="tbPopMean" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:TextBox ID="tbPopStdDev" runat="server" Width="128px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvFirstName0" runat="server" ControlToValidate="tbPopStdDev" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
            <td class="auto-style51">
                    <asp:Panel ID="panAuto" runat="server" Width="417px" Height="172px">
                    <table class="auto-style32">
                        <tr>
                            <td class="auto-style53">
                                <asp:Label ID="labSampleSizeA" runat="server" Text="Sample Size:"></asp:Label>
                                &nbsp;
                                <asp:TextBox ID="tbSampleSizeA" runat="server" Width="128px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="rfvFirstName1" runat="server" ControlToValidate="tbSampleSizeA" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            <td class="auto-style15">
                                <asp:Label ID="labStdDev" runat="server" Text="Standard Deviation:"></asp:Label>
                                &nbsp;&nbsp;
                                <br />
                                <asp:TextBox ID="tbStdDev" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="rfvFirstName2" runat="server" ControlToValidate="tbStdDev" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">
                                <asp:Label ID="labMean" runat="server" Text="Mean:"></asp:Label>
                                &nbsp;&nbsp;<asp:TextBox ID="tbMean" runat="server" Width="125px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvFirstName3" runat="server" ControlToValidate="tbMean" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            <td class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="bAutoCalc" runat="server" OnClick="bAutoCalc_Click" Text="Calculate test statistic..." Width="195px" />
                            </td>
                        </tr>
                    </table>

                   </asp:Panel>
                </td>
        </tr>
        <tr>
            <td class="auto-style39">
                    <asp:Panel runat="server" ID="panSelectAuto" Visible="true">
                        <table class="auto-style36">
                            <tr>
                                <td>Enter statistics about the sample?&nbsp;&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="bAutoSample" runat="server" OnClick="bAutoSample_Click" Text="Auto" Width="105px" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    </td>
            <td class="auto-style45">
                    <asp:Panel runat="server" ID="panSelectManual" Visible="true">
                        <table class="auto-style35">
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                    </td>
            <td>
                    <asp:Panel ID="panManual" runat="server" Width="420px" Height="128px">
                        Enter your observations separated by a comma:<br />
                        <asp:TextBox ID="tbEnterObs" runat="server" TextMode="MultiLine" Height="48px" Width="341px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="bManualCalc" runat="server" Text="Calculate test statistic..." OnClick="bManualCalc_Click" />
                   </asp:Panel>
                </td>
        </tr>
    </table>
        
    
    <br />
  
        <table class="auto-style34">
            <tr>
                

                <td class="auto-style46">
                    <asp:Panel ID="panAutoZ" runat="server" Width="372px" Visible="False">
                    <table>
                        <tr>
                            <td class="auto-style28">
                                <asp:Label ID="labAutoAlpha" runat="server" Text="Alpha Level:"></asp:Label>
                            </td>
                            <td class="auto-style29">
                                <asp:Label ID="autoAlpha" runat="server" Text="Label"></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labAutoTwoTailed" runat="server" Text="Dichotomy:"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="autoTwoTailed" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labAutoCriticalZ" runat="server" Text="Critical Z:"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="autoCriticalZ" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labAutoObservedZ" runat="server" Text="Observed Z:" ForeColor="Blue"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="autoObservedZ" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
                            </td>
                        </tr>
                    </table>
                        <br />
                        <asp:Button ID="bAutoHypTest" runat="server" Text="Run hypothesis test..." OnClick="bAutoHypTest_Click" />
                    </asp:Panel>
                </td>

                <td class="auto-style47">
                    <asp:Panel ID="panManualZ" runat="server" Width="370px" Visible="False">
                    <table>
                        <tr>
                            <td class="auto-style28">
                                <asp:Label ID="labManAlpha" runat="server" Text="Alpha Level:"></asp:Label>
                            </td>
                            <td class="auto-style29">
                                <asp:Label ID="manAlpha" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labManTwoTailed" runat="server" Text="Dichotomy:"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="manTwoTailed" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labManCriticalZ" runat="server" Text="Critical Z:"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="manCriticalZ" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style30">
                                <asp:Label ID="labManObservedZ" runat="server" Text="Observed Z:" ForeColor="Blue"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="manObservedZ" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
                            </td>
                        </tr>
                    </table>
                        <br />
                        <asp:Button ID="bManHypTest" runat="server" Text="Run hypothesis test..." OnClick="bManHypTest_Click" />
                    </asp:Panel>
                </td>
                   
            </tr>
            <tr>
               

                <td class="auto-style19">
                    <asp:Panel ID="panAutoResults" runat="server">
                    The observed Z is of <asp:Label ID="labAutoHypObsZ" runat="server" Text="Label"></asp:Label>
&nbsp;magnitude than the critical Z<br />
                    <br />
                    The hypothesis test is
                    <asp:Label ID="labAutoPassFail" runat="server" Text="Label"></asp:Label>
&nbsp;with
                    <asp:Label ID="labAutoConfidence" runat="server" Text="Label"></asp:Label>
&nbsp;confidence
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="panManualResults" runat="server">
                    The observed Z is of <asp:Label ID="labManHypObsZ" runat="server" Text="Label"></asp:Label>
&nbsp;magnitude than the critical Z<br />
                    <br />
                    The hypothesis test is
                    <asp:Label ID="labManPassFail" runat="server" Text="Label"></asp:Label>
&nbsp;with
                    <asp:Label ID="labManConfidence" runat="server" Text="Label"></asp:Label>
&nbsp;confidence
                        </asp:Panel>
                </td>
                
            </tr>
        </table>
        <br />
    </asp:Content>
