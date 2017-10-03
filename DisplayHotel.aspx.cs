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

public partial class DisplayHotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CityID"] != null)
        {
            int CityID = Convert.ToInt32(Session["CityID"]);
            fillHotel(CityID);
            fillCityName(CityID);
        }
        else
        {
            Response.Redirect("~/Home.aspx");
        }
    }
    private void fillHotel(int CityID)
    {
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        DataTable table = hotelObj.getAllHotelDataByCity(CityID,ref Error);
        GridViewHotel.DataSource = table;
        GridViewHotel.DataBind();


    }
    private void fillCityName(int CityID)
    {
        string Error = "";
        DBCity cityObj = new DBCity();
        LabelCityName.Text = cityObj.getCityNameByID(CityID,ref Error);
    }
    protected void Button_Click(object sender, EventArgs e)
    {
        
    }
    protected void GridViewHotel_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            int HotelID = Convert.ToInt32(GridViewHotel.DataKeys[e.Row.RowIndex].Value.ToString());
            string Error = "";
            DBHotelRoom roomObj = new DBHotelRoom();
            DataTable table = roomObj.getAllHotelRoomByHotel(HotelID, ref Error);
            if (Error != "")
            {
                Response.Write(Error);
            }
            else
            {
                GridView inner = (GridView)e.Row.FindControl("GridViewRooms");
                inner.DataSource = table;
                inner.DataBind();
            }
        }
    }
    protected void GridViewHotel_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewHotel.PageIndex = e.NewPageIndex;
        int CityID = Convert.ToInt32(Session["CityID"]);
        fillHotel(CityID);
    }
    protected void GridViewHotel_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Message")
        {
            int HotelID = Convert.ToInt32(e.CommandArgument);
            Session["HotelID"] = HotelID;
            Response.Redirect("~/SendInquiry.aspx");
        }  
    }
}
