<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStatus.aspx.cs" Inherits="MiniTorrent.EnableUseraspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 440px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Welcome To Status Update"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;<asp:Label ID="lblUserId" runat="server" Text="Enter User Id: "></asp:Label>
             
            &nbsp;<asp:TextBox ID="tbUserId"  runat="server" Height="25px" Width="174px"> </asp:TextBox>
            </p>
        <p>
            <asp:Label ID="lblStatus" runat="server" Text="Mark Status:"></asp:Label>
            <asp:CheckBox ID="cbStatus" runat="server" />
            </p>
        <p style="margin-left: 480px">
            <asp:Button ID="btEnable" runat="server" Text="Update Status" />
        </p>
    </form>
</body>
</html>
