<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubREP_page.aspx.cs" Inherits="finalyarab.ClubREP_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Club_rep" runat="server">
        <div>
            My Club:<br />
            <asp:Label ID="myclub" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Club_info_Club_rep_Button" runat="server" Text="Button" OnClick="Club_info_Club_rep_Button_Click" />
            <br />
            <br />
            Upcoming Matches:<br />
            <asp:Label ID="upcomingM" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Upcoming_matches_Club_rep_Button" runat="server" Text="Button" OnClick="Upcoming_matches_Club_rep_Button_Click" />
            <br />
            <br />
            Available Stadiums:<br />
            Date:
            <br />
            <asp:TextBox ID="Date_available_Stadiums_Club_rep" runat="server"></asp:TextBox>
            <asp:Button ID="available_Stadium_Button" runat="server" Text="Submit" OnClick="available_Stadium_Button_Click" />
            <br />
            <asp:Label ID="availbe_stadium" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Send a Request to a Stadium Manager:<br />
            Stadium Name:<br />
            <asp:TextBox ID="Send_stadium_name_Club_rep" runat="server"></asp:TextBox>
            <br />
            Date :<br />
            <asp:TextBox ID="Send_Date_Club_rep" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Send_Club_rep_Button" runat="server" Text="Submit" OnClick="Send_Club_rep_Button_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
