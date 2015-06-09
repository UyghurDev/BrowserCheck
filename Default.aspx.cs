using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Browser_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckBrowser();
    }


    private void CheckBrowser()
    {
        try
        {



            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.Web.HttpBrowserCapabilities bc = Request.Browser;

            setValue(imgBrowser, "images/" + bc.Browser.Trim() + ".png", bc.Browser.Trim());
            setValue(imgCookies, boolean2imageString(bc.Cookies), bc.Cookies.ToString().Trim());
            setValue(imgJS, boolean2imageString(bc.JavaScript), bc.JavaScript.ToString().Trim());
            setValue(imgVBS, boolean2imageString(bc.VBScript), bc.VBScript.ToString().Trim());
            setValue(imgOS, checkOS(bc.Platform), bc.Platform.Trim());
            setValue(imgCSS, boolean2imageString(bc.SupportsCss), bc.SupportsCss.ToString().Trim());
            lblScreenWidth.Text = bc.ScreenPixelsWidth.ToString() + "px";
            lblScreenHeight.Text = bc.ScreenPixelsHeight.ToString() + "px";
            setValue(imgTable, boolean2imageString(bc.Tables), bc.Tables.ToString().Trim());
            lblIp.Text = Request.UserHostAddress;
            lblLang.Text = Request.UserLanguages[0];
            setValue(imgActivX, boolean2imageString(bc.ActiveXControls), bc.ActiveXControls.ToString());
            setValue(imgFram, boolean2imageString(bc.Frames), bc.Frames.ToString());

            //sb.Append("Browser:" + bc.Browser);
            //sb.Append("<br/>");
            //sb.Append("canSendEmail:" + bc.CanSendMail.ToString());
            //sb.Append("<br/>");
            //sb.Append("Cookies:" + bc.Cookies.ToString());
            //sb.Append("<br/>");
            //sb.Append("getwayMajorVersion:" + bc.GatewayMajorVersion.ToString());
            //sb.Append("<br/>");
            //sb.Append("getwayMinorVersion:" + bc.GatewayMinorVersion.ToString());
            //sb.Append("<br/>");
            //sb.Append("getwayVersion:" + bc.GatewayVersion);
            //sb.Append("<br/>");
            //sb.Append("IsColor:" + bc.IsColor.ToString());
            //sb.Append("<br/>");
            //sb.Append("IsMobileDevice:" + bc.IsMobileDevice.ToString());
            //sb.Append("<br/>");
            //sb.Append("JavaScript :" + bc.JavaScript.ToString());
            //sb.Append("<br/>");
            //sb.Append("JScriptVersion:" + bc.JScriptVersion.ToString());
            //sb.Append("<br/>");
            //sb.Append("MobileDeviceModel:" + bc.MobileDeviceModel);
            //sb.Append("<br/>");
            //sb.Append("Platform:" + bc.Platform);
            //sb.Append("<br/>");
            //sb.Append("RendersWmlDoAcceptsInline:" + bc.RendersWmlDoAcceptsInline.ToString());
            //sb.Append("<br/>");
            //sb.Append("RendersWmlSelectsAsMenuCards:" + bc.RendersWmlSelectsAsMenuCards.ToString());
            //sb.Append("<br/>");
            //sb.Append("ScreenBitDepth:" + bc.ScreenBitDepth.ToString());
            //sb.Append("<br/>");
            //sb.Append("ScreenPixelsHeight:" + bc.ScreenPixelsHeight.ToString());
            //sb.Append("<br/>");
            //sb.Append("ScreenPixelsWidth:" + bc.ScreenPixelsWidth.ToString());
            //sb.Append("<br/>");
            //sb.Append("SupportsCss:" + bc.SupportsCss.ToString());
            //sb.Append("<br/>");
            //sb.Append("SupportsXmlHttp:" + bc.SupportsXmlHttp.ToString());
            //sb.Append("<br/>");
            //sb.Append("Tables:" + bc.Tables.ToString());
            //sb.Append("<br/>");
            //sb.Append("Version:" + bc.Version);
            //sb.Append("<br/>");
            //sb.Append("Win16:" + bc.Win16.ToString());
            //sb.Append("<br/>");
            //sb.Append("Win32:" + bc.Win32.ToString());

            //sb.Append("<br/>");
            //sb.Append("Culture:" + Page.Culture);
            //sb.Append("<br/>");
            //sb.Append("UserLanguages:" + Page.Request.UserLanguages);
            //sb.Append("<br/>");
            //sb.Append("UserHostAddress:" + Request.UserHostAddress);
            //sb.Append("<br/>");
            //sb.Append("ئاساسى رايۇن بىر قۇر");
            //sb.Append("<br/>");
            //sb.Append("ﻛﻪﯕﻪﻳﺘﯩﻠﮕﻪﻥ ﺑﯩﺮ ﻗﯘﺭ");
            //sb.Append("<br/>");
            //sb.Append("ئاساسى رايۇن كۆپ قۇرلۇق تېكىست يېزىش سىنىقى ئېلىپ بېرىلىۋاتىدۇ شۇڭا ئۇزۇن قىلىپ يېزىۋاتىمەن. بىر قۇردىن ئېشىشىنى ئۈمۈد قىلىمەن.");
            //sb.Append("<br/>");
            //sb.Append("ﻛﻪﯕﻪﻳﺘﯩﻠﮕﻪﻥ ﺭﺍﻳﯘﻥ ﻛﯚﭖ ﻗﯘﺭﻟﯘﻕ ﺗﯧﻜﯩﺴﺖ ﺳﯩﻨﯩﻘﻰ. ﺑﯩﺮ ﻗﯘﺭﺩﯨﻦ ﺋﯧﺸﯩﺸﻨﻰ ﺋﯜﻣﯜﺩ ﻗﯩﻠﯩﻤﻪﻥ. ﺯﺍﺩﻯ ﺑﯩﺮ ﻗﯘﺭﺩﯨﻦ ﺋﺎﺷﻤﯩﺴﺎ ﺑﻮﻟﻤﺎﻳﺪﯗ. ﻛﯩﭽﯩﻚ ﺗﯩﭙﺘﯩﻜﻰ ﻳﺎﻥ ﺋﯜﺳﻜﯜﻧﯩﻠﻪﺭ ﻛﯚﺯﺩﻩ ﺗﯘﺗﯩﻠﯩﺪﯗ.");
            //sb.Append("<br/>");


            //ltrlResult.Text = sb.ToString();

        }
        catch (Exception ex)
        {

            //ltrlResult.Text = ex.Message;
        }

        
    }

    private void setValue(Image img, string value, string title)
    {
        img.ImageUrl = value; ;
        img.ToolTip = title;
    }

    private string boolean2imageString(Boolean bln)
    {
        string temp = "images/"+bln.ToString() + ".png";
        return temp;
    }

    private string checkOS(string strPlatform)
    {
        string strTemp = "";
        if (strPlatform.ToLower().Contains("win"))
        {
            strTemp = "images/win.png";
        }
        return strTemp;
    }
}
