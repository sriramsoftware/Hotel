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

public partial class Admin_AdminEditHotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["HotelID"] == null)
        {
            Response.Redirect("~/Admin/AdminHotel.aspx");
        }
        if (!IsPostBack)
        {
            fillCity();
            fillHotel();
        }
    }
    private void fillHotel()
    {
        int HotelID = Convert.ToInt32(Session["HotelID"].ToString());
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        DataTable table = hotelObj.getHotelData(HotelID, ref Error);
        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            DataRow row = table.Rows[0];

            TextBoxName.Text = row["HotelName"].ToString();
            TextBoxPhone.Text = row["Phone"].ToString();
            TextBoxState.Text = row["State"].ToString();
            TextBoxEmail.Text = row["Email"].ToString();
            TextBoxDesc.Text = row["HotelDiscription"].ToString();
            TextBoxAdd.Text = row["Address"].ToString();
            int CityID = Convert.ToInt32(row["CityID"].ToString());
            DropDownListCity.Items.FindByValue(CityID.ToString()).Selected = true;
            ImageHotel.ImageUrl = row["ImageUrl"].ToString();
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
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBHotel hotelObj = new DBHotel();
        string path = Server.MapPath("~/HotelImage/");
        string fileName = FileUploadImage.FileName;
        string DBPath = "";
        if (fileName.Trim().Equals(""))
        {
            DBPath = ImageHotel.ImageUrl;
        }
        else
        {
            string FullPath = path + fileName;

            FileUploadImage.SaveAs(FullPath);
            DBPath = "~/HotelImage/" + fileName;
        }
        int CityID = Convert.ToInt32(DropDownListCity.SelectedValue);
        int HotelID = Convert.ToInt32(Session["HotelID"].ToString());
        hotelObj.updateHotel(HotelID, CityID, TextBoxName.Text, TextBoxAdd.Text, TextBoxState.Text, TextBoxPhone.Text, TextBoxDesc.Text, TextBoxEmail.Text, DBPath, ref Error);

        if (Error != "")
        {
            Response.Write(Error);
        }
        else
        {
            fillHotel();
        }

    }
    protected void ButtonCancle_Click(object sender, EventArgs e)
    {
        fillHotel(); 
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/AdminHotel.aspx");
    }
}
