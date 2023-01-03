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
    

    <h2>לעדכן את הטבלה</h2>
    <asp:Label ID ="Label1" runat="server" Text="באיזה ID אתה רוצה לשנות?" ></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" type="number"></asp:TextBox>
     <br />
    <asp:Label ID ="Label2" runat="server" Text="את הערך:" ></asp:Label>
   <asp:DropDownList ID="DropDownList2" runat="server">
      
        <asp:listitem text="שם" value="name"></asp:listitem>
         <asp:listitem text="קבוצה" value="team_num"></asp:listitem>
        <asp:listitem text="מקצה" value="game_num"></asp:listitem>
       <asp:listitem text="עזב את הקו" value="AtonLeaveLine"></asp:listitem>
       <asp:listitem text="כדורים לנמוך באוטונומי" value="AtonLow"></asp:listitem>
       <asp:listitem text="כדורים לגבוה באוטונומי" value="AtonHigh"></asp:listitem>
       <asp:listitem text="כדורים לנמוך בטלאופ" value="TeleopLow"></asp:listitem>
       <asp:listitem text="כדורים לגבוה בטלאופ" value="TeleopHigh"></asp:listitem>
       <asp:listitem text="כדורים שפספס" value="missed"></asp:listitem>
       <asp:listitem text="טיפוס" value="climb"></asp:listitem>
       <asp:listitem text="האם נשבר" value="TeleopBrake"></asp:listitem>

    </asp:DropDownList>
     <br />
     <br />

    <asp:Label ID ="Label3" runat="server" Text="לערך:" ></asp:Label>
     <br />

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
     <asp:Button ID="Button6" runat="server" Text="לשנות!" OnClick ="Button6_Click" />

     <br />
    <h2>למחוק שורה</h2>
     <asp:Label ID ="Label4" runat="server" Text="מה הID של השורה שאתה רוצה למחוק?" ></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" type="number" ></asp:TextBox>
    <br />
    <asp:Button ID="Button7" runat="server" Text="מחק!" OnClick ="Button7_Click" />

</asp:Content>