using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Configuration;


public class DBConnection
{
	public DBConnection()
	{
		
	}
    public static SqlConnection getDBConnection()
    {
        string connString = WebConfigurationManager.ConnectionStrings["HotelConnString"].ToString();
        SqlConnection conn = new SqlConnection(connString);
        return conn;

    }
}
