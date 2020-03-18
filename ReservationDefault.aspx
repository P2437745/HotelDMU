<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationDefault.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:ListBox ID="lstReservation" runat="server" Height="144px" Width="140px"></asp:ListBox>
            <asp:Button ID="Apply" runat="server" Text="Apply" OnClick="Apply_Click" />
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
        </p>
        <p>
            <asp:Label ID="lblError1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="lblReservation" runat="server" Text="Enter Reservation Details"></asp:Label>
        <asp:TextBox ID="txtReservasion" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <body bgcolor="powderblue"></body>
    </form>
</body>
</html>
