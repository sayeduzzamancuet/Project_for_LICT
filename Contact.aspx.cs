using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Mail;
using System.Net.Mail;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // string from = "eliaszamanonline@gmail.com";
        string name = nameTextBox.Text;
        string subject = subjectTextBox.Text;
        string message = MessageTextBox.Text;
        try
        {
            System.Net.Mail.MailMessage objemail = new System.Net.Mail.MailMessage();
            objemail.From = new MailAddress("eliaszamanonline@gmail.com");

            objemail.To.Add(new MailAddress("eliaszamanonline@gmail.com"));
            objemail.Subject = subject;
            objemail.IsBodyHtml = true;
            objemail.Body = message+"user Email: "+emailTextBox.Text;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Send(objemail);
            Response.Write("<script>alert('Your message has been sent')</script>");
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('Failed'+ex.message)</script>");
        }
    }
}