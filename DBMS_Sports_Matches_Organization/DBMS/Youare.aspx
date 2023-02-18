<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Youare.aspx.cs" Inherits="finalyarab.Youare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link href="firstpage.css" rel="stylesheet" />
</head>
<body>
    <h2>Select what you are </h2>
    <div class="first">
        
        
        <form runat="server">
            <asp:Button ID="AssociationManager" OnClick="samSQL" runat="server" Text="Association Manager" cssclass="btnsam"/>
            <asp:Button ID="ClubRepresentative" OnClick="crSQL" runat="server" Text="Club Representative" cssclass="btncr"/>
            <asp:Button ID="StadiumManager" OnClick="smSQL" runat="server" Text="StadiumManager" cssclass="btnsm"/>
            <asp:Button ID="fan" OnClick="fanSQL" runat="server" Text="Fan" cssclass="btnfan"/>
        </form>
    </div>

</body>
</html>