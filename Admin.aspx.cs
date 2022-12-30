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

		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [missed], [climb], [TeleopBrake] FROM [table] ";
		
			using (MyDB db = new MyDB())
			{

				var cmd_replies = db.Command(sql1);
				GridView1.DataSource = cmd_replies.GetTable();
				GridView1.DataBind();
			
		}


	}
	protected void Button2_Click(object sender, EventArgs e)
	{

		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [missed], [climb], [TeleopBrake] FROM [table] WHERE [team_num] = {0}";

		using (MyDB db = new MyDB())
		{

			var cmd_replies = db.Command(sql1, Txt.Text);
			GridView1.DataSource = cmd_replies.GetTable();
			GridView1.DataBind();

		}


	}
	protected void Button3_Click(object sender, EventArgs e)
	{

		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [missed], [climb], [TeleopBrake] FROM [table] WHERE [game_num] = {0} ";

		using (MyDB db = new MyDB())
		{

			var cmd_replies = db.Command(sql1, Txt.Text);
			GridView1.DataSource = cmd_replies.GetTable();
			GridView1.DataBind();

		}


	}
	protected void Button4_Click(object sender, EventArgs e)
	{

		string sql1 = "SELECT [name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [missed], [climb], [TeleopBrake] FROM [table] WHERE [name] = {0} ";

		using (MyDB db = new MyDB())
		{

			var cmd_replies = db.Command(sql1, Txt.Text);
			GridView1.DataSource = cmd_replies.GetTable();
			GridView1.DataBind();

		}


	}
	protected void Button5_Click(object sender, EventArgs e)
	{

		Response.Redirect("forum.aspx");
	}
}