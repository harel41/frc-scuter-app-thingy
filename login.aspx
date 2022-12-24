<%@ Page Title="בחירת קבוצה" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    
        <asp:Label  runat="server" Text="שם סקאוטר" AssociatedControlID ="TxtScouterName"></asp:Label>
        <asp:TextBox ID="TxtScouterName" runat="server"></asp:TextBox>
        <br />
        <asp:Label  runat="server" Text="מספר קבוצה" AssociatedControlID ="NumTeam"></asp:Label>
        <asp:TextBox ID="NumTeam" runat="server"></asp:TextBox>
        <br />
        <asp:Label  runat="server" Text="מספר מקצה" AssociatedControlID ="NumGame"></asp:Label>
        <asp:TextBox ID="NumGame" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMessage" runat="server" ></asp:Label>
        <asp:Button ID="BtnLogin" runat="server" Text="להתחיל!" OnClick ="BtnLogin_Click" />
       
  
</asp:Content>

