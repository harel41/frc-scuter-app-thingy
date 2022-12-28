using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void AdminSend_click(object sender, EventArgs e)
    {
        string sql = "INSERT INTO [Admin] ([name], [user_type])" +
                " VALUES ({0}, {1})";
        using (MyDB db = new MyDB())
        {
            var cmd = db.Command(sql, Session["name"], "Admin");
            cmd.ExecuteNonQuery();
            Response.Redirect("Admin.aspx");

        }
    }

}