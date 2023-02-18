<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssociationManager.aspx.cs" Inherits="finalyarab.AssociationManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Association Manager Reg<br />
        Name<br />
        <asp:TextBox ID="Association_Manager_NAME" runat="server"></asp:TextBox>
        <br />
        UserName<br />
        <asp:TextBox ID="Association_Manager_USERNAME" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <br />
        <asp:TextBox ID="Association_Manager_PASSWORD" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Association_Manager_REG" runat="server" Text="REGISTER" OnClick="Association_Manager_REG_Click1" />
    </form>
</body>
</html>

