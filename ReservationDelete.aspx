<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationDelete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this reservation"></asp:Label>
        </div>
        <asp:Button ID="btnDeleteYes" runat="server" OnClick="btnDeleteYes_Click" Text="Yes" />
        <asp:Button ID="btnDeleteNo" runat="server" OnClick="btnDeleteNo_Click" Text="No" />
        <body bgcolor="powderblue"></body>
    </form>
</body>
</html>
