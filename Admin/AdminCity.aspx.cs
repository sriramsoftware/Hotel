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

public partial class Admin_AdminCity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }
        

        if (!IsPostBack)
        {
            fillCity();
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBCity cityObj = new DBCity();
        cityObj.addCity(TextBoxCityName.Text, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            TextBoxCityName.Text = "";
            fillCity();
        }

    }
    private void fillCity()
    {
        string Error = "";
        DBCity cityObj = new DBCity();
        DataTable table = cityObj.getAllCity(ref Error);
        GridViewCity.DataSource = table;
        GridViewCity.DataBind();
    }
    protected void GridViewCity_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewCity.EditIndex = e.NewEditIndex;
        fillCity();

      
    }
    protected void GridViewCity_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewCity.EditIndex = -1;
        fillCity();
    }
    protected void GridViewCity_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int cityID = Int32.Parse(GridViewCity.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBCity cityObj = new DBCity();
        cityObj.deleteCity(cityID, ref Error);

        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {

            fillCity();
        }
    }
    protected void GridViewCity_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        int cityID = Int32.Parse(GridViewCity.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBCity cityObj = new DBCity();
        string CityName = ((TextBox)GridViewCity.Rows[e.RowIndex].FindControl("TextBoxCity")).Text;
        cityObj.updateCity(cityID, CityName, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            GridViewCity.EditIndex = -1;
            fillCity();
        }
    }
}
