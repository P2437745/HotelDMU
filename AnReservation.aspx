<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnReservation.aspx.cs" Inherits="AnReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblReservationID" runat="server" Text="ReservationID"></asp:Label>
            <asp:TextBox ID="txtReservationID" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number of Rooms"></asp:Label>
            <asp:TextBox ID="txtNoRooms" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Number of Adults"></asp:Label>
            <asp:TextBox ID="txtNoAdults" runat="server"></asp:TextBox>
        </p>
        <p id="lblError">
            <asp:Label ID="Label5" runat="server" Text="Number of Children"></asp:Label>
            <asp:TextBox ID="txtNoChildren" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label runat="server" Text="Reservation Date"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Reservation Due Date"></asp:Label>
            <asp:TextBox ID="txtDueDate" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="txtContinue" runat="server" OnClick="txtContinue_Click" Text="Continue" />
        <asp:Button ID="txtClear" runat="server" Text="Clear this Form" OnClick="txtClear_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <body bgcolor="powderblue"></body>
    </form>
</body>
</html>
