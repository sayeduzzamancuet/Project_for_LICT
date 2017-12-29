using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Text;
using System.Data.Linq;
public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowDetailDataContext d = new ShowDetailDataContext();

        GridView2.DataSource = from tutorial in d.Tutorials
                               where tutorial.Id == Convert.ToInt32(Request.QueryString["id"])
                               select tutorial;
        GridView2.DataBind();
        foreach (GridViewRow gr in GridView2.Rows)
        {

            HyperLink hp = new HyperLink();
            hp.Text = "Click here";
            hp.NavigateUrl ="http://"+gr.Cells[6].Text;
            gr.Cells[6].Controls.Add(hp);
        }
    }

}