<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fan_page.aspx.cs" Inherits="finalyarab.fan_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            all matches:<br />
            --please Enter--<br />
            Date:
            <br />
            <asp:TextBox ID="Date_ViewAllmatches_Fan" runat="server"></asp:TextBox>
            <br />
            <br />
            Available Matches<br />

        </div>
        <asp:Button ID="ViewAllmatches_Fan_Button" runat="server" Text="view" OnClick="ViewAllmatches_Fan_Button_Click" />
        <br />
      
        </form>

        
    

    
</body>
</html>
