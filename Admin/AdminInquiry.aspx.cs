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

public partial class Admin_AdminInquiry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            fillMessage();
        }
    }
    private void fillMessage()
    {
        string Error = "";
        DBMessage msgObj = new DBMessage();
        DataTable table= msgObj.getAllMessage(ref Error);

        GridViewMessage.DataSource = table;
        GridViewMessage.DataBind();

    }
    protected void GridViewMessage_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label Message = (Label)e.Row.FindControl("LabelMessage");

            Label dateAndTimeLabel = (Label)e.Row.FindControl("LabelDate");
            DateTime dateTime = Convert.ToDateTime(dateAndTimeLabel.Text);
            DateTime CurrentDate = DateTime.Now;

            if (Message.Text.Length >= 50)
            {
                Message.Text = Message.Text.Substring(0, 50) + "...";
            }

            if (dateTime.ToShortDateString() == CurrentDate.ToShortDateString())
            {
                dateAndTimeLabel.Text = dateTime.ToShortTimeString();
            }
            else
            {
                dateAndTimeLabel.Text = dateTime.ToShortDateString();
            }
        }

    }
   
    protected void GridViewMessage_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int MessageID = Int32.Parse(GridViewMessage.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBMessage msgObj = new DBMessage();
        msgObj.deleteMessage(MessageID, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            fillMessage();
        }
    }
    protected void GridViewMessage_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Read")
        {
            Session["MessageID"] = e.CommandArgument;
            Response.Redirect("~/Admin/AdminShowMessage.aspx");
        }
    }
}
