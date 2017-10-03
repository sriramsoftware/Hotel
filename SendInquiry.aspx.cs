using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class SendInquiry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["HotelID"] == null)
        {
            Response.Redirect("~/DisplayHotel.aspx");
        }
        else
        {
            fillName();
        }
    }
    private void fillName()
    {
        int HotelId=Convert.ToInt32(Session["HotelID"]);
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        TextBoxHotelName.Text=hotelObj.getHotelName(HotelId,ref Error);
    }
    protected void ButtonSend_Click(object sender, EventArgs e)
    {
        int HotelId=Convert.ToInt32(Session["HotelID"]);
        string Error = "";
        DBMessage msgObj = new DBMessage();
        msgObj.addMessage(HotelId, TextBoxName.Text, TextBoxEmail.Text, TextBoxPhone.Text,TextBoxMessage.Text, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            Response.Redirect("~/DisplayHotel.aspx");
        }
    }
}
