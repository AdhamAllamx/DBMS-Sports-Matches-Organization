<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubRepresentative.aspx.cs" Inherits="finalyarab.ClubRepresentative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ClubRepresentative Reg<br />
            <br />
            <br />
            <br />
            Name
            <br />
            <asp:TextBox ID="club_representative_Name" runat="server"></asp:TextBox>
            <br />
            UserName
            <br />
            <asp:TextBox ID="club_representative_UserName" runat="server"></asp:TextBox>
            <br />
            Password
            <br />
            <asp:TextBox ID="club_representative_password" runat="server"></asp:TextBox>
            <br />
            Club Name
            <br />
            <asp:TextBox ID="club_representative_Club_Name" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="club_representative_regester" runat="server" Text="Regester" OnClick="club_representative_regester_Click" />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
