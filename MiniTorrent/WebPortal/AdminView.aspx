<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminView.aspx.cs" Inherits="MiniTorrent.AdminView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

<!-- #include file ="_Layout.html" -->



    <form id="form1" runat="server">
        <div style="margin-left: 350px">
            <asp:Label ID="Label1" runat="server" Text="Welcome To View Mode Of System" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        </div>
        <div>
            <br />
            <asp:Label ID="lblSearch" runat="server" Text="Enter File Name To Search:"></asp:Label>
            <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAllFiles" runat="server" Text="Files In System:"></asp:Label>
            <br />
            <br />
            <asp:MultiView ID="Files" runat="server">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:MultiView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Total Files In System:"></asp:Label>
            <asp:Label ID="lblFiles" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Total Active Users In System"></asp:Label>
            <asp:Label ID="lblActiveUsers" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
