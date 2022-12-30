<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="scripts/Myscript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">

    <p>ברוכים הבאים לאתר סקווטינג </p>
     <br />
    <asp:Label ID ="Label2" runat="server" Text="בבקשה תכניס את שמך:" ></asp:Label>
    <br />
    <asp:TextBox ID="TxtName" runat="server" onkeyup ="isNameGood()"></asp:TextBox>
     <br />

    <asp:Button ID="Button1" runat="server" Text="להיכנס!" OnClick ="Login_Click" />

    <asp:Button ID="Button2" runat="server" Text="להירשם כאדמין!" OnClick ="Admin_Click" />
     <br />
    <asp:Label ID="lblMessage" runat="server" ></asp:Label>
</asp:Content>

