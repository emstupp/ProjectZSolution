using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZPRO.Model;
using ZPRO.PublicSiteController;

namespace ProjectZ.PublicSite
{
    public partial class TStatistic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panAutoTSample.Visible = false;

        }





        protected void bAutoSample_Click(object sender, EventArgs e)
        {
            panAutoTSample.Visible = true;
        }

    }
}