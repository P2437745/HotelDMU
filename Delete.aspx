<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 73px; top: 156px; position: absolute" Text="Are you want to delete this roomtype ?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 78px; top: 186px; position: absolute; height: 26px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 123px; top: 186px; position: absolute; height: 26px; width: 33px" Text="No" />
    </form>
</body>
</html>
