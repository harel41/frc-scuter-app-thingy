<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="scripts/Myscript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <asp:Label ID ="Label1" runat="server" Text="הכנס את הסיסמא הנכונה כדי לרשום את השם הזה בתור אדמין:" ></asp:Label>
    <br />
    <asp:Label ID ="Label2" runat="server" Text="(כל פעם שתכנס לאתר ותשתמש בשם הזה הוא יחבר אותך בתור אדמין)" ></asp:Label>
    <br />
    <asp:TextBox ID="Password" runat="server" type ="password"  />
    <br />
    <asp:Label ID="lblMessage" runat="server" ></asp:Label>
    <asp:Button runat="server" Text="תרשום!" OnClick="AdminSend_click" />
</asp:Content>

