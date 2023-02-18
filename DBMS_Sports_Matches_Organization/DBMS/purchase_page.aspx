<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="purchase_page.aspx.cs" Inherits="finalyarab.purchase_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="add date to see avalabile matches after it "></asp:Label>
            <asp:TextBox ID="Date_ViewAllmatches_Fan" runat="server"></asp:TextBox><asp:Button ID="see" runat="server" Text="see" OnClick="see_Click" />
            <br />
            <br />
            National ID:
            <asp:TextBox ID="national_ID_text" runat="server"></asp:TextBox>
             host club:
            <asp:TextBox ID="host_text" runat="server"></asp:TextBox>
             guest club:
            <asp:TextBox ID="guest_text" runat="server"></asp:TextBox>
            start time:
            <asp:TextBox ID="time_text" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="purchase_button" runat="server" Text="purchase" OnClick="purchase_button_Click" />
    </form>
</body>
</html>
