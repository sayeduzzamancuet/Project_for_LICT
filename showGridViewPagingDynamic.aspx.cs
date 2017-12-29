
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class showGridViewPagingDynamic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("ljhkmjhgkh");
        DataTable dtTutorial = new DataTable();
       // GridView1.Visible = true;
       // GridView1.AutoGenerateColumns = false;
       // GridView1.AllowPaging = true;
       //// GridView1.OnPageIndexChanging = "OnPageIndexChanging";
       // GridView1.PageSize = 10;
        SqlConnection con;

        using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
        {
            SqlCommand cmd = new SqlCommand("Select id,Topic,Description,link FROM Tutorial Where UniversityName='CUET' AND Department='CSE' AND Subject='Algorithm'", con);


            dtTutorial.Columns.Add("Topic");
            dtTutorial.Columns.Add("Description");
            dtTutorial.Columns.Add("Visit");
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DataRow dr = dtTutorial.NewRow();
                dr["Topic"] = rdr["Topic"];
                dr["Description"] = rdr["Description"];
                dr["Visit"] = rdr["id"];
                dtTutorial.Rows.Add(dr);
            }
            con.Close();
        }
        GridView1.DataSource = dtTutorial;
        GridView1.DataBind();
        foreach (GridViewRow gr in GridView1.Rows)
        {
            HyperLink hp = new HyperLink();
            //hp.Text = gr.Cells[2].Text;
            hp.Text = "Click here";
            hp.NavigateUrl = "~/Details.aspx?id=" + gr.Cells[2].Text;
            gr.Cells[2].Controls.Add(hp);
        }
    }
    //private void BindGrid()
    //{
    //    string constr = WebConfigurationManager.ConnectionStrings["ConnStringDb"].ConnectionString;
    //    using (SqlConnection con = new SqlConnection(constr))
    //    {
    //        using (SqlCommand cmd = new SqlCommand("Select id,Topic,Description,link FROM Tutorial"))
    //        {
    //            using (SqlDataAdapter sda = new SqlDataAdapter())
    //            {
    //                cmd.Connection = con;
    //                sda.SelectCommand = cmd;
    //                using (DataTable dt = new DataTable())
    //                {
    //                    sda.Fill(dt);
    //                    GridView1.DataSource = dt;
    //                    GridView1.DataBind();
    //                }
    //            }
    //        }
    //    }
    //}
    //protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewPageIndex;
    //    this.BindGrid();
    //}
}