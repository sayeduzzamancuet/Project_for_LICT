using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RandomQuote : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // string selectedQuote = "Random qoute goes here";
        Label1.Text = "";
        Random rnd = new Random();
        int n = rnd.Next(1,10);
        DBOperation dbOp = new DBOperation();
        string selectedQuote = dbOp.randomQouteSelection(n);
        Label1.Text = selectedQuote;
    }
}