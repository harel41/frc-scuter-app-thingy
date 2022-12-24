<%@ Page Title="אתר סקווטינג" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
	<asp:TextBox ID="TxtGameNum" runat="server" ></asp:TextBox>
	<br />
	<asp:Label ID="lblMessage" runat="server" ></asp:Label>
	   <br />
	<asp:Button runat="server" Text="התחל!" OnClick="AddNewDefault_Click" />
</asp:Content>



