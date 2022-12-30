<%@ Page Title="אתר סקווטינג" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forum.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	 <script src="scripts/Myscript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
	
    <h2>לפני המקצה</h2>
	
	<asp:Label runat="server" Text="מספר קבוצה:" ></asp:Label>
	<asp:TextBox ID="TxtTeamNum" runat="server" onkeyup ="isTeamNumGood()" ></asp:TextBox>
	<br />
	<asp:Label runat="server" Text="מספר מקצה:" ></asp:Label>
	<asp:TextBox ID="TxtGameNum" runat="server" onkeyup ="isGameNumGood()" ></asp:TextBox>
	<br />
	<asp:Label ID="lblMessage" runat="server" ></asp:Label>
	   <br />

	<h2>אוטונומי</h2>
	<asp:Label runat="server" Text=" הרובוט יצא מהקו" ></asp:Label>
    <asp:CheckBox ID = "robotLeaveLine"  runat="server" />
   <br />
	<asp:Label ID ="Label1" runat="server" Text=" מספר כדורים לנמוך:" ></asp:Label>
	<asp:TextBox ID="AtonLowNum" runat="server" type="number" min ="0" />
	<br />
	<asp:Label ID ="Label2" runat="server" Text=" מספר כדורים לגבוה:" ></asp:Label>
	<asp:TextBox ID="AtonHighNum" runat="server" type="number" min ="0" />

	<h2>טלאופ</h2>
	<asp:Label ID ="Label3" runat="server" Text=" מספר כדורים לנמוך:" ></asp:Label>
	<asp:TextBox ID="TeleopLowNum" runat="server" type="number" min ="0" />
	<br />
	<asp:Label ID ="Label4" runat="server" Text=" מספר כדורים לגבוה:" ></asp:Label>
	<asp:TextBox ID="TeleopHighNum" runat="server" type="number" min ="0" />
	<br />
	<asp:Label ID ="Label5" runat="server" Text=" מספר כדורים שהוחמצו:" ></asp:Label>
	<asp:TextBox ID="TeleopMissed" runat="server" type="number" min ="0" />
	<br />
	<asp:Label ID ="Label6" runat="server" Text=" לאיזה מוט הרובוט טיפס (אם הוא לא טיפס נא להשאיר ריק)?:" ></asp:Label>
	<br />
	<asp:Label ID ="Label7" runat="server" Text="מוט 1" ></asp:Label>
	<asp:CheckBox ID="climb1" runat="server" />
	<br />
	<asp:Label ID ="Label8" runat="server" Text="מוט 2" ></asp:Label>
	<asp:CheckBox ID="climb2" runat="server" />
	<br />
	<asp:Label ID ="Label9" runat="server" Text="מוט 3" ></asp:Label>
	<asp:CheckBox ID="climb3" runat="server" />
	<br />
	<asp:Label ID ="Label10" runat="server" Text="מוט 4" ></asp:Label>
	<asp:CheckBox ID="climb4" runat="server" />
	<br />
	<asp:Label runat="server" Text=" הרובוט נשבר?" ></asp:Label>
    <asp:CheckBox ID = "broken"  runat="server" />
	<br />
	<asp:Button runat="server" Text="תשלח!" OnClick="AddNewDefault_Click" />
	<asp:Button runat="server" Text="לחזור לדף הראשי" OnClick="GoBack_Click" />
	<asp:Table ID="Table1" runat="server"></asp:Table>
</asp:Content>


	