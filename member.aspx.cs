using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string Email, Password;
        Email = TextBox1.Text;
        Password = TextBox2.Text;
        DBOperation obj = new DBOperation();
        bool t=obj.login(Email,Password);
        if (t == true)
        {
            Session["Email"] = Email;
          //  Response.Redirect("member_home.aspx");
           Response.Redirect("~/admin/insert_tutorial.aspx");
        }
        else
        {
            Label1.Text = "Wrong Username or password";  
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("create.aspx");
    }
}