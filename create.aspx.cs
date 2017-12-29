using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string Email = TextBox1.Text;
        string Password = TextBox2.Text;
        string confirmPassword = TextBox3.Text;
        if (Password == confirmPassword)
        {
            Session["createEmail"] = Email;
            Session["createPassword"] = Password;
            Response.Redirect("confirmEmail.aspx");
        }
        if(Password!=confirmPassword)
        {
            
            //Response.Write("<script>alert('Password do not match')</script>");
            Label1.Text = "Password do not match";
        }
        
        
                
    }
}