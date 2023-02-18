<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemAdmin_page.aspx.cs" Inherits="finalyarab.SystemAdmin_page" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add A Club:<br />
            <br />
            --Please Enter--<br />
            -Name of the Club :<br />
&nbsp;<asp:TextBox ID="Name_Club_addclub_System_admin" runat="server"></asp:TextBox>
            <br />
            -Location:
            <br />
            <asp:TextBox ID="Location_Club_addclub_System_admin" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server"  Text="Button" style="direction: ltr" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            Delete A Club:<br />
            <br />
            --Please Enter--<br />
            -Name of the Club<br />
            <asp:TextBox ID="Name_club_Deleteclub_System_admin" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Deleteclub_System_admin_Bitton" runat="server" Text="Submit" OnClick="Deleteclub_System_admin_Bitton_Click" />
            <br />
            <br />
            Add A Stadium:<br />
            <br />
            --please Enter--
            <br />
            -Name of the Stadium:<br />
            <asp:TextBox ID="Name_Stadium_AddStadium_System_admin" runat="server"></asp:TextBox>
            <br />
            -Stadium Location:<br />
            <asp:TextBox ID="Location_Stadium_AddStadium_System_admin" runat="server"></asp:TextBox>
            <br />
            -Stadium Capacity:<br />
            <asp:TextBox ID="Capacuty_Stadium_AddStadium_System_admin" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="AddStadium_System_admin_Button" runat="server" Text="Submit" OnClick="AddStadium_System_admin_Button_Click" />
            <br />
            <br />
            Delete A Stadium:<br />
            <br />
            --please Enter--<br />
            -Stadium Name<br />
            <asp:TextBox ID="Name_Stadium_DeleteStadium_System_admin" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="DeleteStadium_System_admin_Button" runat="server" Text="Submit" OnClick="DeleteStadium_System_admin_Button_Click" />
            <br />
            <br />
            <br />
            Block Fan :<br />
            <br />
            --Please Enter--<br />
            -Fan National ID
            <br />
            <br />
            <asp:TextBox ID="Fan_Name_BlockFan_System_admin" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BlockFan_System_admin_button" runat="server" Text="Submit" OnClick="BlockFan_System_admin_button_Click" />
        </div>
    </form>
</body>
</html>
