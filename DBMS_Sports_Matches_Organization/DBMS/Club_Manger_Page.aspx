<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Club_Manger_Page.aspx.cs" Inherits="finalyarab.Club_Manger_Page" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    

    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="View all related information of My Stadium:"></asp:Label>
            <asp:Button runat="server" Text="Button" OnClick="Unnamed2_Click"></asp:Button>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
             <asp:Label runat="server" Text="View all request information:">

             </asp:Label><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label><asp:GridView runat="server" DataSourceID="SqlDataSource2" ID="ctl05"></asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="<%$ ConnectionStrings:milestone3ConnectionString5 %>" SelectCommand="select * from dbo.seehisreq(@username)">
                <SelectParameters>
                    <asp:SessionParameter SessionField="StadiumManager_UserName" DefaultValue="" Name="username"></asp:SessionParameter>
                </SelectParameters>
            </asp:SqlDataSource><asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
            <br />
            <asp:Label runat="server" Text="Accept req:"></asp:Label>
            <br />
            <asp:TextBox ID="hostclub" placeholder="Host Club" runat="server"></asp:TextBox>
            <asp:TextBox ID="guestclub" placeholder="Guest Club" runat="server"></asp:TextBox>
            <asp:TextBox ID="timee"  placeholder="Start Time" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Accept" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
