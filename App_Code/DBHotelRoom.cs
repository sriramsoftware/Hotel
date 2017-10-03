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

public class DBHotelRoom
{
	public DBHotelRoom()
	{
	
	}
    public DataTable getAllHotelRoomByHotel(int HotelID,ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select hr.NoOfRoom,hr.RoomPrice,rm.RoomTypeName from hotelroom hr inner join roomtype rm on rm.RoomTypeID=hr.RoomTypeID where hr.HotelID=" + HotelID;
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
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
    public DataTable getAllHotelRoom(ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            string query = "select h.HotelName,hr.NoOfRoom,hr.RoomPrice,hr.HotelID,hr.HotelRoomID,rm.RoomTypeName from hotelroom hr inner join roomtype rm on rm.RoomTypeID=hr.RoomTypeID inner join hotel h on h.HotelID=hr.HotelID order by h.HotelName;";
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
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
    public void addHotelRoom(int RoomTypeID,int HotelID,int NoOfRoom,double RoomPrice, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "insert into hotelroom(RoomTypeID,HotelID,NoOfRoom,RoomPrice)values(" + RoomTypeID +","+HotelID+","+NoOfRoom+","+RoomPrice+")";
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
    public void deleteHotelRoom(int RoomTypeID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "delete from hotelroom where HotelRoomID=" + RoomTypeID;
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
    public void updateHotelRoom(int HotelRoomID,int NoOfRooms,double RoomPrice, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "update hotelroom set NoOfRoom=" + NoOfRooms + ", RoomPrice="+RoomPrice +" where HotelRoomId=" +HotelRoomID ;
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
