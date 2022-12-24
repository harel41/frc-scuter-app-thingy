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
    protected void AddNewDefault_Click(object sender, EventArgs e)
	{
		
	
		
			string sql = "INSERT INTO [table] ([name], [team_num], [game_num])" +
				" VALUES ({0}, {1}, {2})";
			using (MyDB db = new MyDB())
			{
				var cmd = db.Command(sql, Txtname.Text, TxtTeamNum.Text, TxtGameNum.Text);
				cmd.ExecuteNonQuery();
			}
		
	}
}