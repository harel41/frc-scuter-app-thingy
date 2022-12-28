<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
    
    <asp:TextBox ID="TxtNum" runat="server"></asp:TextBox>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="תראה לי!" OnClick ="Button1_Click" />
</asp:Content>

