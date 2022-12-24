<%@ Page Title="אתר סקווטינג" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	 <script src="scripts/Myscript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <p>ברוכים הבאים לאתר סקווטינג </p>
    <h2>הכנס נתונים</h2>
	<asp:Label runat="server" Text="שם סקאוטר:" ></asp:Label>
	<asp:TextBox ID="Txtname" runat="server" ></asp:TextBox>
	<br />
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
    <asp:Button runat="server" Text="+" OnClick ="PlusLow_Click" />
    <asp:Label runat="server" Text=" מספר לנמוך" ></asp:Label>
    <asp:Button runat="server" Text="-" OnClick ="MinusLow_Click" />
    <br />
    <asp:Button runat="server" Text="+" OnClick ="PlusHigh_Click"/>
    <asp:Label runat="server" Text=" מספר לגבוה" ></asp:Label>
    <asp:Button runat="server" Text="-" OnClick ="MinusHigh_Click" />
	<asp:Label ID ="Num" runat="server" Text=" קליקים" ></asp:Label>
     <br />

	<asp:Button runat="server" Text="תשלח!" OnClick="AddNewDefault_Click" />
	<asp:Button runat="server" Text="תנקה הכל" OnClick="GoBack_Click" />
</asp:Content>



