<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="finalyarab.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link href="stylelogin.css" rel="stylesheet" />
</head>
<body>
    <div class="loginbox">
        
        <h2>Login</h2>
        <form runat="server">
            <asp:Label cssclass="iblemail" runat="server" Text="Username"></asp:Label>
            <asp:TextBox runat="server" CssClass="txtemail" placeholder="Enter Email" ID="username" />
            <asp:Label cssclass="iblepass" runat="server" Text="Password"></asp:Label>

            <asp:TextBox runat="server" CssClass="txtpass" placeholder="****" ID="Password" />
            <asp:Button ID="submit" OnClick="LoginSQL" runat="server" Text="Submit" cssclass="btnsubmit"/>
            <asp:Button ID="register" OnClick="registerSQL" runat="server" Text="register here" cssclass="hyp"/>            
            `
        </form>
    </div>
      

</body>
</html>


