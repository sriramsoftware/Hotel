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

public partial class Admin_HotelRoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
        if (!IsPostBack)
        {
            fillHotelRoom();
            fillHotel();
            fillRoomType();
        }
        
    }
    private void fillRoomType()
    {
        string Error = "";
        DBHotelType typeObj = new DBHotelType();
        DataTable table = typeObj.getAllRoomType(ref Error);

        DropDownListRoomType.DataSource = table;
        DropDownListRoomType.DataTextField = "RoomTypeName";
        DropDownListRoomType.DataValueField = "RoomTypeID";
        DropDownListRoomType.DataBind();


    }
    private void fillHotel()
    {
        string Error = "";
        DBHotel typeObj = new DBHotel();
        DataTable table = typeObj.getAllHotelData(ref Error);

        DropDownListHotel.DataSource = table;
        DropDownListHotel.DataTextField = "HotelName";
        DropDownListHotel.DataValueField = "HotelID";
        DropDownListHotel.DataBind();
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBHotelRoom typeObj = new DBHotelRoom();
        int RoomTypeID = Convert.ToInt32(DropDownListRoomType.SelectedValue);
        int HotelID = Convert.ToInt32(DropDownListHotel.SelectedValue);
        int NoOfRoom = Convert.ToInt32(TextBoxNoOFRooms.Text);
        double RoomPrice = Convert.ToInt64(TextBoxPrice.Text);

        typeObj.addHotelRoom(RoomTypeID, HotelID, NoOfRoom, RoomPrice, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            TextBoxNoOFRooms.Text = "";
            TextBoxPrice.Text = "";
            fillHotelRoom();
        }
    }
    private void fillHotelRoom()
    {
        string Error = "";
        DBHotelRoom roomObj = new DBHotelRoom();
        DataTable table=roomObj.getAllHotelRoom(ref Error);
        GridViewHotelRoom.DataSource = table;
        GridViewHotelRoom.DataBind();

    }
    protected void GridViewHotelRoom_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int TypeID = Int32.Parse(GridViewHotelRoom.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBHotelRoom cityObj = new DBHotelRoom();
        cityObj.deleteHotelRoom(TypeID, ref Error);

        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {

            fillHotelRoom();
        }

    }
    protected void GridViewHotelRoom_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int HotelRoomID = Int32.Parse(GridViewHotelRoom.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBHotelRoom cityObj = new DBHotelRoom();
        int NoOfRoom =Convert.ToInt32( ((TextBox)GridViewHotelRoom.Rows[e.RowIndex].FindControl("TextBoxNoOfRoom")).Text);
        double price = Double.Parse(((TextBox)GridViewHotelRoom.Rows[e.RowIndex].FindControl("TextBoxPrice")).Text);
        cityObj.updateHotelRoom(HotelRoomID, NoOfRoom, price, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            GridViewHotelRoom.EditIndex = -1;
            fillHotelRoom();
        }
    }
    protected void GridViewHotelRoom_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewHotelRoom.EditIndex = e.NewEditIndex;
        fillHotelRoom();
    }
    protected void GridViewHotelRoom_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewHotelRoom.EditIndex = -1;
        fillHotelRoom();
    }
}
