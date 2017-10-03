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

public class DBAdmin
{
	public DBAdmin()
	{
		
	}
    public bool getAdminLogin(string AdminName, string Password, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(AdminName) from AdminLogin where AdminName='" + AdminName + "' and Password='" + Password + "'", conn);
            Object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                return false;
            }
            else
            {
                int count = Convert.ToInt32(obj);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            Error = ex.Message;
            return false;
        }
        finally
        {
            conn.Close();
        }
    }
}
