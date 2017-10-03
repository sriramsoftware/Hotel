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

public partial class RoomType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            fillRoomType();
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBHotelType typeObj = new DBHotelType();
        typeObj.addRoomType(TextBoxRoomType.Text, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            TextBoxRoomType.Text = "";
            fillRoomType();
        }
    }
    private void fillRoomType()
    {
        string Error = "";
        DBHotelType obj = new DBHotelType();
        DataTable table = obj.getAllRoomType(ref Error);
        GridViewRoomType.DataSource = table;
        GridViewRoomType.DataBind();
    }
    protected void GridViewRoomType_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int RoomTypeID = Int32.Parse(GridViewRoomType.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBHotelType cityObj = new DBHotelType();
        string RoomType = ((TextBox)GridViewRoomType.Rows[e.RowIndex].FindControl("TextBoxRoomType")).Text;
        cityObj.updateRoomType(RoomTypeID,RoomType, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            GridViewRoomType.EditIndex = -1;
            fillRoomType();
        }
    }
    protected void GridViewRoomType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRoomType.EditIndex = e.NewEditIndex;
        fillRoomType();

    }
    protected void GridViewRoomType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewRoomType.EditIndex = -1;
        fillRoomType();
    }
    protected void GridViewRoomType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int TypeID = Int32.Parse(GridViewRoomType.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBHotelType cityObj = new DBHotelType();
        cityObj.deleteRoomType(TypeID, ref Error);

        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {

            fillRoomType();
        }
    }
}
