using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public class DB
{
    private static readonly string _connectionString;
public DataTable GetAll()
{
// Initialize the DataAdapter
SqlDataAdapter dad = new SqlDataAdapter("SELECT * FROM Tutorial ", _connectionString);
// Create a DataTable
DataTable dtblTutorial = new DataTable();
// Populate the DataTable
dad.Fill(dtblTutorial);
// Return results
return dtblTutorial;
}

	static DB()
	{
		_connectionString = WebConfigurationManager.ConnectionStrings["ConnStringDb"].ConnectionString;
}
}