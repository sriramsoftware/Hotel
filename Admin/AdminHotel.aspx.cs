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

public partial class Admin_AdminHotel : System.Web.UI.Page
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
            fillHotel();
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        string path=Server.MapPath("~/HotelImage/");
        string fileName=FileUploadImage.FileName;
        string FullPath=path+fileName;

        FileUploadImage.SaveAs(FullPath);
        string DBPath="~/HotelImage/"+fileName;
        int CityID=Convert.ToInt32(DropDownListCity.SelectedValue);

        hotelObj.addHotel(TextBoxName.Text,TextBoxAdd.Text,TextBoxState.Text,TextBoxPhone.Text,TextBoxDesc.Text,TextBoxEmail.Text,DBPath,CityID,ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {

        }
    }
    private void fillCity()
    {
        string Error = "";
        DBCity cityObj = new DBCity();
        DataTable table = cityObj.getAllCity(ref Error);
        DropDownListCity.DataSource = table;
        DropDownListCity.DataValueField = "CityID";
        DropDownListCity.DataTextField = "CityName";
        DropDownListCity.DataBind();
       
    }
    private void fillHotel()
    {
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        DataTable table = hotelObj.getAllHotelData(ref Error);
        GridViewHotel.DataSource = table;
        GridViewHotel.DataBind();
        

    }
    protected void GridViewHotel_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewHotel.EditIndex = -1;
        fillHotel();
    }
    protected void GridViewHotel_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int hotelID = Convert.ToInt32(GridViewHotel.DataKeys[e.RowIndex].Value.ToString());
        string Error = "";
        DBHotel obj = new DBHotel();
        obj.deleteHotel(hotelID,ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            fillHotel();
        }
    }
    protected void GridViewHotel_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        
    }
    protected void GridViewHotel_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewHotel.EditIndex = e.NewEditIndex;
        fillHotel();
    }
    protected void GridViewHotel_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditHotel")
        {
            Session["HotelID"] = e.CommandArgument;
            Response.Redirect("~/Admin/AdminEditHotel.aspx");
        }
    }
}
