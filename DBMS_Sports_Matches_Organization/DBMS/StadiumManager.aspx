<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StadiumManager.aspx.cs" Inherits="finalyarab.StadiumManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Stadium Manger Reg<br />
        Name<br />
        <asp:TextBox ID="StadiumManager_NAME" runat="server"></asp:TextBox>
        <br />
        UserName<br />
        <asp:TextBox ID="StadiumManager_USERNAME" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="StadiumManager_PASSWORD" runat="server"></asp:TextBox>
        <br />
        Stadum Name<br />
        <asp:TextBox ID="StadiumManager_Stadum_Name" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="StadiumManager_REG" runat="server" Text="REGISTER" OnClick="StadiumManager_REG_Click1" />
    </form>
</body>
</html>
