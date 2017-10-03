using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MainMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillCity();
    }
    private void fillCity()
    {
        string Error = "";
        DBCity cityObj = new DBCity();
        DataTable table= cityObj.getAllCity(ref Error);
        DataListCity.DataSource = table;
        DataListCity.DataBind();
    }
    protected void DataListCity_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "City")
        {
            Session["CityID"] = e.CommandArgument;
            Response.Redirect("~/DisplayHotel.aspx");
        }
    }
}
