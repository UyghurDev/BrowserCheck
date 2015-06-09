<%@ Page Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Browser_Default" Title="Browser Capabilities" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 400px;
        }
        .style2
        {
            text-align: center;
        }
    </style>
    <asp:HyperLink ID="lnkSimple" runat="server" 
        NavigateUrl="~/Browser/detectadv.aspx">ئاددى نۇسخىسى(Simple)</asp:HyperLink>
<br />
    <br />
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                مەشغۇلات سىستېمىسى(OS):</td>
            <td class="style2">
                <asp:Image ID="imgOS" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                جاھاننەما(Browser):</td>
            <td class="style2">
                <asp:Image ID="imgBrowser" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                Cookies:</td>
            <td class="style2">
                <asp:Image ID="imgCookies" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                JavaScript:</td>
            <td class="style2">
                <asp:Image ID="imgJS" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                VBScript:</td>
            <td class="style2">
                <asp:Image ID="imgVBS" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                ActivX:
            </td>
            <td class="style2">
                <asp:Image ID="imgActivX" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                ئىكران كەڭلىكى( Screen Width ):</td>
            <td class="style2">
                <asp:Label ID="lblScreenWidth" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                ئىكران ئىگىزلىكى(Screen Height):</td>
            <td class="style2">
                <asp:Label ID="lblScreenHeight" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                CSS:</td>
            <td class="style2">
                <asp:Image ID="imgCSS" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                جەدىۋەل(Table):</td>
            <td class="style2">
                <asp:Image ID="imgTable" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                Fram:</td>
            <td class="style2">
                <asp:Image ID="imgFram" runat="server" Height="64px" Width="64px" />
            </td>
        </tr>
        <tr>
            <td>
                IP:</td>
            <td class="style2">
                <asp:Label ID="lblIp" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                تىل(Language):</td>
            <td class="style2">
                <asp:Label ID="lblLang" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>




