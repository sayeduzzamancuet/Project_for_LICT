using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetExpires(DateTime.Now.AddMinutes(5));
        Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
        Response.Cache.SetValidUntilExpires(true); 
       
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //LabelSpentTime.Text = DateTime.Now.ToString();
    }
}
