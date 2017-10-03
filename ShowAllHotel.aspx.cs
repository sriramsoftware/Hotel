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

public partial class ShowAllHotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillHotel();
        }
    }
    private void fillHotel()
    {
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        DataTable table = hotelObj.getAllHotelData(ref Error);
        DataListHotel.DataSource = table;
        DataListHotel.DataBind();


    }
    protected void DataListHotel_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Hotel")
        {
            Session["CityID"] = e.CommandArgument;
            Response.Redirect("~/DisplayHotel.aspx");
        }
    }
    protected void DataListHotel_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
