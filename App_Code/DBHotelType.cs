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

public class DBHotelType
{
	public DBHotelType()
	{
		
	}
    public DataTable getAllRoomType(ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from roomtype", conn);
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
    public void addRoomType(string RoomTypeName, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "insert into roomtype(RoomTypeName)values('" + RoomTypeName + "')";
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
    public void deleteRoomType(int RoomTypeID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "delete from roomtype where RoomTypeID=" + RoomTypeID;
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
    public void updateRoomType(int RoomTypeID, string RoomTypeName, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "update roomtype set RoomTypeName='" + RoomTypeName + "' where RoomTypeID=" + RoomTypeID;
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
}
