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

public class DBCity
{
    public DBCity()
    {

    }
    public DataTable getAllCity(ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from City", conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            return table;

        }
        catch (Exception ex)
        {
            Error = ex.Message;
            return null;
        }

    }
    public void addCity(string CityName, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "insert into city(CityName)values('" + CityName + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


        }
        catch (Exception ex)
        {
            Error = ex.Message;

        }
        finally
        {
            conn.Close();
        }
    }
    public void deleteCity(int CityID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "delete from City where CityID="+CityID;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


        }
        catch (Exception ex)
        {
            Error = ex.Message;

        }
        finally
        {
            conn.Close();
        }
    }
    public void updateCity(int CityID,string CityName, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "update city set CityName='"+CityName+"' where CityID="+CityID;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


        }
        catch (Exception ex)
        {
            Error = ex.Message;

        }
        finally
        {
            conn.Close();
        }
    }
    public string getCityNameByID(int CityID,ref string Error){
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "select CityName from City where CityID=" + CityID;
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteScalar().ToString();


        }
        catch (Exception ex)
        {
            Error = ex.Message;
            return null;
        }
        finally
        {
            conn.Close();
        }
    }

}
