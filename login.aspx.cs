using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        using (MyDB db = new MyDB())
        {
            string sql = "SELECT  [team_num], [game_num] FROM [Table] WHERE [name]={0}";
            var command = db.Command(sql, TxtScouterName.Text);
            var row = command.GetFirstRow();
            if (row != null && (string)row["game_num"] == NumGame.Text)
            {
               
                Session["name"] = TxtScouterName.Text;
                Session["team_num"] = row["team_num"];
                Session["game_num"] = row["game_num"];
                Response.Redirect(".");


            }
            else
                lblMessage.Text = "לא עובד אחי";
        }
          
    }
}