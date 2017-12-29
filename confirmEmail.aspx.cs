using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Net.Mail;
using RandomNumber;//Generates random number and return the value in string format
public partial class confirmEmail : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["createEmail"] as string))
        {
            Label1.Text = null;
        }
        if (!string.IsNullOrEmpty(Session["createEmail"] as string))
        {
            string userEmail = Session["createEmail"].ToString();
            string userPassword = Session["createPassword"].ToString();

            Session["_email"] = userEmail;
            Session["_password"] = userPassword;


           // Random rn = new Random();
            //int randomNumber = rn.Next(100000, 999999);
            RandomGenerator obj = new RandomGenerator();
            string _rndNumber = obj.randomNumber(100000,999999);
            //Session["_rndNumber"] = randomNumber.ToString();
            Session["_rndNumber"] = _rndNumber;

            string subject = "Confirm registration code";
            try
            {
                using (MailMessage mm = new MailMessage("zamansayed4@gmail.com", userEmail))
                {
                    mm.Subject = subject;
                    mm.Body = Session["_rndNumber"].ToString();
                   
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("zamansayed4@gmail.com", "a22334455");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
                }
            }
            //try
            //{

            //    System.Net.Mail.MailMessage objemail = new System.Net.Mail.MailMessage();
            //    objemail.From = new MailAddress("zamansayed4@gmail.com");

            //    objemail.To.Add(new MailAddress(userEmail));
            //    objemail.Subject = subject;
            //    objemail.IsBodyHtml = true;
            //    objemail.Body = Session["_rndNumber"].ToString();
            //    SmtpClient client = new SmtpClient();
            //    client.EnableSsl = true;
            //    client.Send(objemail);

            //    // Response.Write("<script>alert('Pin has been sent to your email. Please open it.')</script>");
            //    Label1.Text = "Pin has been sent to your email. Please confirm it.";
            //}
            catch (Exception ex)
            {
                Response.Write("<script>alert('Failed to send email'+ex.message)</script>");
            }
            finally
            {
                Session.Remove("createEmail");
                Session.Remove("createPassword");
                //Session["Email"] = null;
                //Session["Password"] = null;
            }
        }

    }
    protected void ButtonPinConfirm_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(TextBoxPin.Text) == (Convert.ToInt32(Session["_rndNumber"].ToString())))
        {
            DBOperation cr = new DBOperation();
            cr.create(Session["_email"].ToString(), Session["_password"].ToString());
            Session["Email"] = Session["_email"];
            Session.Remove("_rndNumber");
            Session.Remove("_email");
            Session.Remove("_password");


            Response.Write("<script>alert('Congrats! Your account has been created succesfully!!')</script>");
            Response.Redirect("~/admin/insert_tutorial.aspx");

        }
        else
        {
            Response.Write("<script>alert('Pin do not match')</script>");

        }
    }
}