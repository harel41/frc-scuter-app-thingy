using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{

	}

	/*protected void Page_PreRender(object sender, EventArgs e)
	{
		
		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [climb], [TeleopBrake] FROM [table]  WHERE [id] = {0}";
		for (int i = 0; i < int.Parse(TxtNum.Text); i++)

			using (MyDB db = new MyDB())
		{
			
			var cmd_replies = db.Command(sql1,2);
			GridView1.DataSource = cmd_replies.GetTable();
			GridView1.DataBind();
		}
	}
	*/


	protected void Button1_Click(object sender, EventArgs e)
	{

		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [climb], [TeleopBrake] FROM [table]  WHERE [id] = {0}";
		for (int i = 0; i < int.Parse(TxtNum.Text); i++)
		{
			using (MyDB db = new MyDB())
			{

				var cmd_replies = db.Command(sql1, 2);
				GridView1.DataSource = cmd_replies.GetTable();
				GridView1.DataBind();
			}
		}


	}
}