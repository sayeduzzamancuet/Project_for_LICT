using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public class DBOperation
{
    SqlConnection con;

    public DBOperation()
    {
        con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnStringDb"].ToString());
    }

    public bool login(string email, string password)
    {
        PasswordHash obj = new PasswordHash();
        string _password = obj.encryption(password);
        SqlCommand cmd;
        string query = "Select * from Login where Email='" + email + "' AND Password='" + _password + "'";
        cmd = new SqlCommand(query, con);
        con.Open();
        var res = cmd.ExecuteScalar();
        con.Close();
        if (res != null)
            return true;
        else
            return false;
    }

    public bool create(string email, string password)
    {
        PasswordHash obj=new PasswordHash();
        string _password = obj.encryption(password);

        SqlCommand cmd;
        string query = "insert into Login (Email,Password) VALUES ('" + email + "','" + _password + "');";
        cmd = new SqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        return true;
    }

    public bool changePassword(string Email, string oldpassword, string newpassword)
    {
        PasswordHash obj = new PasswordHash();
        string oldP = obj.encryption(oldpassword);
        string newP = obj.encryption(newpassword);

  
        SqlCommand cmd;

        string query = "Update Login set Password='" + newP + "' where Email='" + Email + "' and Password='" + oldpassword + "'";
        cmd = new SqlCommand(query, con);
        con.Open();
        cmd.ExecuteScalar();
        con.Close();
        return true;
    }
    public string randomQouteSelection(int n)
    {
        SqlCommand cmd;
        string query = "Select Text FROM Quotes WHERE id='" + n + "'";
        cmd = new SqlCommand(query, con);
        con.Open();
        string result = (string)cmd.ExecuteScalar();
        con.Close();
        return result;
    }
    public bool insertTutorial(string UniversityName, string Department, string Subject, string Topic, string Description, string link)
    {
        SqlCommand cmd;
        string query = "insert into Tutorial (UniversityName,Department,Subject,Topic,Description,link) VALUES ('" + UniversityName + "','" + Department + "','" + Subject + "','" + Topic + "','" + Description + "','" + link + "')";
        cmd = new SqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public bool deleteTutorial(int i)
    {
        SqlCommand cmd;
        string query = "DELETE FROM Tutorial WHERE Id='" + i + "' ";
        cmd = new SqlCommand(query,con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        return true;
    }
   // public string getTutorialDetail(int indexNumber)
  //  {
        //SqlCommand cmd;
        //SqlDataReader rdr=new SqlDataReader();
        //string detail=null;
        

        //string query = "SELECT UniversityName,Department,Subject,Topic,Description,link FROM Tutorial WHERE id='" + indexNumber + "'";
        //cmd = new SqlCommand(query, con);
        //con.Open();
        //while (rdr.Read())
        //{
        //   detail=detail+rdr[]; 
        //}
        
        //con.Close();
        //return detail;
  //  }

    public void Updates(string uniName, string department)
    {
        SqlCommand cmd;
        string query = "INSERT INTO Updates (University,Department) values('" + uniName + "','" + department + "')";
        cmd = new SqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
   
}