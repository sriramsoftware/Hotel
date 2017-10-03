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

public class DBMessage
{
	public DBMessage()
	{
		
	}
    public DataTable getAllMessage(ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select ms.senderName,ms.MessageID,ms.SenderEmail,ms.SenderPhone,ms.SendDate,ms.HotelID,h.HotelName,ms.Message from Message ms inner join Hotel h on h.HotelID=ms.HotelID order by ms.sendDate desc", conn);
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
    public DataTable getMessageData(int MessageID,ref string Error)
    {
        try
        {
            SqlConnection conn = DBConnection.getDBConnection();
            SqlDataAdapter adpt = new SqlDataAdapter("select ms.senderName,ms.MessageID,ms.SenderEmail,ms.SenderPhone,ms.SendDate,ms.HotelID,h.HotelName,ms.Message from Message ms inner join Hotel h on h.HotelID=ms.HotelID where MessageID=" + MessageID, conn);
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
    public void addMessage(int HotelID,string SenderName,string SenderEmail,string Phone,string Message, ref string Error)
    {
        string Date=DateTime.Now.ToString();
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "insert into message(HotelID,SenderName,SenderEmail,SenderPhone,Message,SendDate)values(" + HotelID + ",'" + SenderName + "','" + SenderEmail +"','"+ Phone + "','" + Message + "','" + Date +"')";
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
    public void deleteMessage(int MessageID, ref string Error)
    {
        SqlConnection conn = DBConnection.getDBConnection();
        try
        {
            conn.Open();
            string query = "delete from Message where MessageID=" + MessageID;
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
