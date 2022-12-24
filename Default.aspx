<%@ Page Title="בורים הבאים" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    	<ul id="ulSubjects" runat="server"></ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <p>ברוכים הבאים לאתר הסקאוטינג </p>
    <h2>הכנס נתונים</h2>
	<asp:Label runat="server" Text="שם סקאוטר:" /><br />
	<asp:TextBox ID="Txtname" runat="server" /><br />
	<asp:Label runat="server" Text="מספר קבוצה:" /><br />
	<asp:TextBox ID="TxtTeamNum" runat="server" /><br />
	<asp:Label runat="server" Text="מספר מקצה:" /><br />
	<asp:TextBox ID="TxtGameNum" runat="server" /><br />
	<asp:Button runat="server" Text="פרסם חידה" OnClick="AddNewRiddle_Click" />
</asp:Content>



