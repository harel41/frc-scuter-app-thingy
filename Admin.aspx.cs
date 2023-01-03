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


	protected void Button1_Click(object sender, EventArgs e)
	{

		string sql1 = "SELECT [id] ,[name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [missed], [climb], [TeleopBrake] FROM [table] ";
		
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

	protected void Button6_Click(object sender, EventArgs e)
	{
		if (DropDownList2.SelectedItem.Value == "name")
		{
			string sql1 = "UPDATE [Table] SET [name] = {0} WHERE [id] = {1} ;";
			
			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "team_num")
		{
			string sql1 = "UPDATE [Table] SET [team_num] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "game_num")
		{
			string sql1 = "UPDATE [Table] SET [game_num] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "AtonLeaveLine")
		{
			string sql1 = "UPDATE [Table] SET [AtonLeaveLine] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}
		else if (DropDownList2.SelectedItem.Value == "AtonLow")
		{
			string sql1 = "UPDATE [Table] SET [AtonLow] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}
		else if (DropDownList2.SelectedItem.Value == "AtonHigh")
		{
			string sql1 = "UPDATE [Table] SET [AtonHigh] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}
		else if (DropDownList2.SelectedItem.Value == "TeleopLow")
		{
			string sql1 = "UPDATE [Table] SET [TeleopLow] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "TeleopHigh")
		{
			string sql1 = "UPDATE [Table] SET [TeleopHigh] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "missed")
		{
			string sql1 = "UPDATE [Table] SET [missed] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "climb")
		{
			string sql1 = "UPDATE [Table] SET [climb] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

		else if (DropDownList2.SelectedItem.Value == "TeleopBrake")
		{
			string sql1 = "UPDATE [Table] SET [TeleopBrake] = {0} WHERE [id] = {1} ;";

			using (MyDB db = new MyDB())
			{

				var cmd = db.Command(sql1, TextBox2.Text, TextBox1.Text);
				cmd.ExecuteNonQuery();

			}
		}

	}

	protected void Button7_Click(object sender, EventArgs e)
	{

		string sql1 = "DELETE FROM [Table] WHERE [Id]= {0}; ";

		using (MyDB db = new MyDB())
		{

			var cmd = db.Command(sql1, TextBox3.Text);
			cmd.ExecuteNonQuery();

		}



	}
}