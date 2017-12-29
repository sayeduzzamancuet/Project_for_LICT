using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Tutorial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {         

        GridView1.Visible = false;
        if (!IsPostBack)
        {
            SqlConnection con;
            using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
            {
                SqlCommand cmd = new SqlCommand("Select Distinct UniversityName FROM Tutorial", con);
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "UniversityName";
                DropDownList1.DataValueField = "UniversityName";
                DropDownList1.DataBind();
                con.Close();
            }
            DropDownList1.Items.Insert(0, new ListItem("select", ""));
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();

        SqlConnection con;
        GridView1.Visible = false;
        using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
        {
            SqlCommand cmd = new SqlCommand("Select Distinct Department FROM Tutorial Where UniversityName='" + DropDownList1.SelectedItem.Value + "'", con);
            con.Open();
            DropDownList2.DataSource = cmd.ExecuteReader();
            DropDownList2.DataTextField = "Department";
            DropDownList2.DataValueField = "Department";
            DropDownList2.DataBind();
            con.Close();
        }
        if (!DropDownList2.SelectedItem.Text.Equals("select"))
        {
            DropDownList2.Items.Insert(0, new ListItem("select", ""));
            DropDownList2.SelectedIndex = 0;
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Clear();
        SqlConnection con;
        using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
        {
            SqlCommand cmd = new SqlCommand("Select Distinct Subject FROM Tutorial Where UniversityName='" + DropDownList1.SelectedItem.Value + "' AND Department='" + DropDownList2.SelectedItem.Value + "'", con);
            con.Open();
            DropDownList3.DataSource = cmd.ExecuteReader();
            DropDownList3.DataTextField = "Subject";
            DropDownList3.DataValueField = "Subject";
            DropDownList3.DataBind();
            con.Close();
        }
        if (!DropDownList3.SelectedItem.Text.Equals("select"))
        {
            DropDownList3.Items.Insert(0, new ListItem("select", ""));
            DropDownList3.SelectedIndex = 0;
        }
        GridView1.Visible = false;
    }

    DataTable dtTutorial = new DataTable();
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            HiddenField1.Value = DropDownList1.SelectedValue;
            HiddenField2.Value = DropDownList2.SelectedValue;
            HiddenField3.Value = DropDownList3.SelectedValue;
        }

        GridView1.Visible = true;
        SqlConnection con;

        using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
        {
            SqlCommand cmd = new SqlCommand("Select id,Topic,Description,link FROM Tutorial Where UniversityName='" + DropDownList1.SelectedItem.Value + "' AND Department='" + DropDownList2.SelectedItem.Value + "' AND Subject='" + DropDownList3.SelectedItem.Value + "'", con);


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
            hp.Text = "Click here";
            hp.NavigateUrl = "~/Details.aspx?id=" + gr.Cells[2].Text;
            gr.Cells[2].Controls.Add(hp);
        }

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Response.Write("<script>alert('hello')</script>");

        GridView1.Visible = true;
        GridView1.DataSource = dtTutorial;
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
        BindData();
    }

    void BindData()
    {
        GridView1.DataSource = dtTutorial;
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        Response.Write("<script>alert('hello')</script>");
    }
}