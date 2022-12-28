using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        Session["name"] = TxtName.Text;
        using (MyDB db = new MyDB())
        {
            string sql = "SELECT [user_type] FROM [Admin] WHERE [name]={0}";
            var command = db.Command(sql, Session["name"]);
            var row = command.GetFirstRow();
            if (row != null && (string)row["user_type"] == "Admin")
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Redirect("forum.aspx");
            }
        }

    }

    protected void Admin_Click(object sender, EventArgs e)
    {
        Session["name"] = TxtName.Text;
        Response.Redirect("AdminLogin.aspx");
    }

}