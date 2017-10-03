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

public partial class Admin_AdminShowMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MessageID"] == null)
        {
            Response.Redirect("~/Admin/AdminInquiry.aspx");
        }
        else
        {
            fillMessage();
        }
    }
    private void fillMessage()
    {
        int MessageID=Convert.ToInt32(Session["MessageID"]);
        string Error = "";
        DBMessage msgObj = new DBMessage();
        DataTable table= msgObj.getMessageData(MessageID, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            DataRow row = table.Rows[0];
            TextBoxName.Text = row["SenderName"].ToString();
            TextBoxPhone.Text = row["SenderPhone"].ToString();
            TextBoxMessage.Text = row["Message"].ToString();
            TextBoxEmail.Text = row["SenderEmail"].ToString();
            TextBoxHotelName.Text = row["HotelName"].ToString();
        }

    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
         int MessageID=Convert.ToInt32(Session["MessageID"]);
        string Error = "";
        DBMessage msgObj = new DBMessage();
        msgObj.deleteMessage(MessageID, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            Response.Redirect("~/Admin/AdminInquiry.aspx");       
        }

    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/AdminInquiry.aspx");
    }
}
