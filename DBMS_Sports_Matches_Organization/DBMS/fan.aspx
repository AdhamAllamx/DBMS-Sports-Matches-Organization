<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fan.aspx.cs" Inherits="finalyarab.fan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="FanRegisterStyle.css" rel="stylesheet" />
</head>
<body>
    <div class="fanbox">

        <h3>Fan Register</h3>
    <form runat="server">

        
            <asp:Label ID="fan_namel" cssclass="iblname" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="Fan_Name" CssClass="txtfan" placeholder="Name" runat="server"></asp:TextBox>
            
            <asp:Label ID="Fan_UserNamel" cssclass="ibluser" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="Fan_UserName" CssClass="txtuser" placeholder="User Name" runat="server"></asp:TextBox>
           
            <asp:Label ID="Fan_passwordl"  cssclass="iblpass" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Fan_password" CssClass="txtpass" placeholder="********" runat="server"></asp:TextBox>
           

            <asp:Label ID="Label3" cssclass="iblid" runat="server" Text="National_ID"></asp:Label>
            <asp:TextBox ID="Fan_National_ID" CssClass="txtid" placeholder="National ID" runat="server"></asp:TextBox>
            

            <asp:Label ID="Label4"  cssclass="iblpn" runat="server" Text="Phone_number"></asp:Label>
            <asp:TextBox ID="Fan_Phone_number" CssClass="txtpn" placeholder="010********" runat="server"></asp:TextBox>
            
            <asp:Label ID="Label5" cssclass="iblbd" runat="server" Text="Birth_date"></asp:Label>
            <asp:TextBox ID="Fan_Birth_date"  CssClass="txtbd" placeholder="Y/M/D" runat="server"></asp:TextBox>
            
            <asp:Label ID="Label6" cssclass="iblfa" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="Fan_Address" CssClass="txtfa" placeholder="Address" runat="server"></asp:TextBox>
            
        <asp:Button ID="Fan_regester" CssClass="br" runat="server" Text="Regester" OnClick="Fan_regester_Click" />
            
        
    </form>
    </div>
</body>
</html>
