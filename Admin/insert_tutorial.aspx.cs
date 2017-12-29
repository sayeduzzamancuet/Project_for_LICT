<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Admin_insert_tutorial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Write("<script>alert('Wrong username Or Password')</script>");
            Response.Redirect("\\member.aspx");
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
        string topic;
        string link;
        universityName = DropDownList1.SelectedItem.Value;
        department = DropDownList2.SelectedItem.Value;
        subject = DropDownList3.SelectedItem.Value;
        topic = TextBoxTopic.Text;
        string Description = TextBoxDescription.Text;
        link = TextBox1.Text;
        DBOperation db = new DBOperation();
        bool ins = db.insertTutorial(universityName, department, subject, topic, Description, link);
        if (ins.Equals("true"))
            Label1.Text = "Inserted!!!";

        db.Updates(DropDownList1.SelectedItem.Value, DropDownList2.SelectedItem.Value);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
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





=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class Admin_insert_tutorial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] == null)
        {
            Response.Write("<script>alert('Wrong username Or Password')</script>");
            Response.Redirect("\\member.aspx");
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
        string topic;
        string link;
        universityName = DropDownList1.SelectedItem.Value;
        department = DropDownList2.SelectedItem.Value;
        subject = DropDownList3.SelectedItem.Value;
        topic = TextBoxTopic.Text;
        string Description = TextBoxDescription.Text;
        link = TextBox1.Text;
        DBOperation db = new DBOperation();
        bool ins = db.insertTutorial(universityName, department, subject, topic, Description, link);
        if (ins.Equals("true"))
            Label1.Text = "Inserted!!!";

        db.Updates(DropDownList1.SelectedItem.Value, DropDownList2.SelectedItem.Value);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
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





>>>>>>> 18ebb5ed3880abe60ae0eb2b11902f44c0c42be2
}