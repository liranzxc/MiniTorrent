<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MiniTorrent.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 400px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Welcome To Register Page"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblUser" runat="server" Text="Enter User Name: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPass" runat="server" Text="Enter Password: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <div style="margin-left: 440px">
            <asp:Button ID="btRegister" runat="server" Text="Register" />
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
