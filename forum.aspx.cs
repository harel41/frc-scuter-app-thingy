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
    string leave;
    string brake;
    string climb;

    protected void AddNewDefault_Click(object sender, EventArgs e)
	{

        if (robotLeaveLine.Checked)
        {
            leave = "yes";
        }
        else
        {
            leave = "no";
        }

        if (broken.Checked)
        {
            brake = "yes";
        }
        else
        {
            brake = "no";
        }

        if (climb4.Checked)
        {
            climb = "4";
        }
        else if (climb3.Checked)
        {
            climb = "3";
        }
        else if (climb2.Checked)
        {
            climb = "2";
        }
        else if (climb1.Checked)
        {
            climb = "1";
        }
        else
        {
            climb = "0";
        }



        string sql = "INSERT INTO [table] ([name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh], [TeleopLow], [TeleopHigh], [climb], [TeleopBrake])" +
				" VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})";
			using (MyDB db = new MyDB())
			{
				var cmd = db.Command(sql, Txtname.Text, TxtTeamNum.Text, TxtGameNum.Text, leave, AtonLowNum.Text, AtonHighNum.Text, TeleopLowNum.Text, TeleopHighNum.Text, climb, brake);
				cmd.ExecuteNonQuery();
                
        }
        
        Response.Redirect(".");
        
    }

	protected void GoBack_Click(object sender, EventArgs e)
    {
		Response.Redirect(".");
	}

    
   

}