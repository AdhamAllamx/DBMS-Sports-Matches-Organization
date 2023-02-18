<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asso_page.aspx.cs" Inherits="finalyarab.asso_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Associationmanger" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="View all matches "></asp:Label><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click2" />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
             <br />
            <br />
            <br />
            <br />
            Add New Match:
            <br />
            <br />
            --Please Enter--<br />
            -Host Club Name
            <br />
            <asp:TextBox ID="Host_Club_name_ADDMatch_Associationmanger" runat="server"></asp:TextBox>
            <br />
            -Guest club name<br />
            <asp:TextBox ID="Guest_Club_name_ADDMatch_Associationmanger" runat="server" ></asp:TextBox>
            <br />
            -Start time<br />
            <asp:TextBox ID="Start_Time_ADDMatch_Associationmanger" runat="server"></asp:TextBox>
            <br />
            -End Time
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ADDMatch_Associationmanger_Button" runat="server" Text="Button" OnClick="ADDMatch_Associationmanger_Button_Click" />
            <br />
            <br />
            Delete New Match:
            <br />
            <br />
            --Please Enter--<br />
            -Host Club Name
            <br />
            <asp:TextBox ID="Host_Club_name_DeleteMatch_Associationmanger" runat="server"></asp:TextBox>
            <br />
            -Guest club name<br />
            <asp:TextBox ID="Guest_Club_name_DeleteMatch_Associationmanger" runat="server" ></asp:TextBox>
            <br />
            -Start time<br />
            <asp:TextBox ID="Start_Time_DeleteMatch_Associationmanger" runat="server"></asp:TextBox>
            <br />
            -End Time
            <br />
            <asp:TextBox ID="End_Time_DeleteMatch_Associationmanger" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="DeleteMatch_Associationmanger_Button" runat="server" Text="Button" OnClick="DeleteMatch_Associationmanger_Button_Click" />
            <br />
            <br />
            Upcoming Matches :<br />
            <asp:Label ID="Label1" runat="server" Text=".."></asp:Label>
            <br />
            <asp:Button ID="View_UpcomingMatches_Associationmanger_button" runat="server" Text="Button" OnClick="View_UpcomingMatches_Associationmanger_button_Click" />
            <br />
            <br />
            Already Played Matches :<br />
            <asp:Label ID="Label2" runat="server" Text=".."></asp:Label>
            <br />
            <asp:Button ID="AlreadyPlayedMatches_Associationmanger_Button" runat="server" Text="Button" OnClick="AlreadyPlayedMatches_Associationmanger_Button_Click" />
            <br />
            <br />
            Pair of club names who never scheduled to play with each other:<br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="NeverPlayedTogether_Associationmanger_button" runat="server" Text="Button" OnClick="NeverPlayedTogether_Associationmanger_button_Click" />
        </div>
    </form>
</body>
</html>
