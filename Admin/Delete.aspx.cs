using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Write("<script>alert('Wrong username Or Password')</script>");
            Response.Redirect("member.aspx");
        }
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string universityName;
        string department;
        string subject;
        int topic_index;

        universityName = DropDownList1.SelectedItem.Value;
        department = DropDownList2.SelectedItem.Value;
        subject = DropDownList3.SelectedItem.Value;
        topic_index = Convert.ToInt32(DropDownList4.SelectedValue);


        DBOperation db = new DBOperation();
        bool del = db.deleteTutorial(topic_index);
        if (del.Equals("true"))
            Label1.Text = "Deleted!!!";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList4.Items.Clear();
        SqlConnection con;
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
        DropDownList4.Items.Clear();
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
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList4.Items.Clear();
        SqlConnection con;
        using (con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString()))
        {
            SqlCommand cmd = new SqlCommand("Select Distinct Topic FROM Tutorial Where UniversityName='" + DropDownList1.SelectedItem.Value + "' AND Department='" + DropDownList2.SelectedItem.Value + "' AND Subject='" + DropDownList3.SelectedItem.Value + "'", con);
            con.Open();
            DropDownList4.DataSource = cmd.ExecuteReader();
            DropDownList4.DataTextField = "Topic";
            DropDownList4.DataValueField = "Topic";
            DropDownList4.DataBind();
            con.Close();
        }
        if (!DropDownList4.SelectedItem.Text.Equals("select"))
        {
            DropDownList4.Items.Insert(0, new ListItem("select", ""));
            DropDownList4.SelectedIndex = 0;
        }
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
}