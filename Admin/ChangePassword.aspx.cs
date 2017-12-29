using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePassword : System.Web.UI.Page
{
    string email;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string oldpass = TextBox1.Text; ;
        string newpass = TextBox2.Text;
        email=Session["Email"] as string;
        DBOperation obj = new DBOperation();
        bool t=obj.changePassword(email,oldpass,newpass);
        if (t == true)
            Label1.Text = "Password Changed Successfully";
        else
            Label1.Text = "Failed";
    }
}