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

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string Error = "";
        DBAdmin adminObj = new DBAdmin();
        if (adminObj.getAdminLogin(TextBoxAdminName.Text, TextBoxPassword.Text, ref Error))
        {
            Session["AdminLogin"] = TextBoxAdminName.Text;
            Response.Redirect("~/Admin/AdminHome.aspx");
        }
        else
        {
            Response.Redirect("~/Admin/AdminLogin.aspx");
        }

    }
}
