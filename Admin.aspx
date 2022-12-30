<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    <h2>כאן אדמינים יכולים להדפיס את הטבלה</h2>
    <br />
    <asp:Button ID="Button5" runat="server" Text=" לענות על הטופס במקום" OnClick ="Button5_Click" />

    <br />
    <asp:Label runat="server" Text="תכתבו כאן את הנתון שאתם רוצים להדפיס את הטבלה ולחצו על הכפתור המתאים" ></asp:Label>
    <br />
    <asp:TextBox ID="Txt" runat="server"></asp:TextBox>
     <br />
    <asp:Button ID="Button1" runat="server" Text="הדפס את כל הטבלה" OnClick ="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="הדפס לפי קבוצה" OnClick ="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="הדפס לפי מקצה" OnClick ="Button3_Click" />
    <asp:Button ID="Button4" runat="server" Text="הדפס לפי שם" OnClick ="Button4_Click" />
     <br />
    
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>

