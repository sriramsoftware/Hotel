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

public class DBHotel
{
	public DBHotel()
	{
	
	}
    public DataTable getAllHotelData(ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from hotel", conn);
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
    public DataTable getAllHotelDataByCity(int CityID ,ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select h.hotelId,h.HotelName,h.CityId,h.Address,h.State,h.Phone,h.HotelDiscription,h.email,h.ImageUrl,cs.CityName from hotel h inner join City cs on cs.CityID=h.CityID where h.CityID=" + CityID, conn);
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
    public void addHotel(string HotelName,string Address,string state,string Phone,string Desc,string email,string imageUrl,int CityID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "insert into hotel(HotelName,CityID,Address,State,Phone,HotelDiscription,Email,ImageURL)values('"+HotelName+"',"+CityID+",'"+Address+"','"+state+"','"+Phone+"','"+Desc+"','"+email+"','"+imageUrl+"')";
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
    public void deleteHotel(int HotelID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "delete from Hotel where HotelID=" + HotelID;
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
    public string  getHotelName(int HotelID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "select HotelName from Hotel where HotelID=" + HotelID;
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
    public DataTable getHotelData(int HotelID,ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select *from hotel where hotelID="+HotelID, conn);
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

    public void updateHotel(int HotelID,int CityID,string HotelName,string Address,string State,string Phone,string Desc,string Email,string ImageUrl, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "update Hotel set HotelName='" +HotelName + "',CityID="+CityID+",Address='"+Address+"',State='"+State+"',Phone='"+Phone+"',HotelDiscription='"+Desc +"',Email='"+Email+"',ImageUrl='"+ImageUrl+"' where HotelID=" + HotelID;
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
