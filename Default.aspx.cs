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

    int AtonLowNum = 0;
    int AtonHighNum = 0;
    string leave;

    protected void MinusLow_Click(object sender, EventArgs e)
    {
        AtonLowNum--;


    }
    protected void PlusLow_Click(object sender, EventArgs e)
    {
        AtonLowNum++;
    }
    protected void MinusHigh_Click(object sender, EventArgs e)
    {
        AtonHighNum--;

    }
    protected void PlusHigh_Click(object sender, EventArgs e)
    {
        AtonHighNum++;
    }

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



            string sql = "INSERT INTO [table] ([name], [team_num], [game_num], [AtonLeaveLine], [AtonLow], [AtonHigh])" +
				" VALUES ({0}, {1}, {2}, {3}, {4}, {5})";
			using (MyDB db = new MyDB())
			{
				var cmd = db.Command(sql, Txtname.Text, TxtTeamNum.Text, TxtGameNum.Text, leave, AtonLowNum, AtonHighNum);
				cmd.ExecuteNonQuery();
			}

	}

	protected void GoBack_Click(object sender, EventArgs e)
    {
		Response.Redirect(".");
	}
   

}