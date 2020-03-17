<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 81px;
            left: 59px;
            z-index: 1;
            width: 184px;
            height: 44px;
        }
        .auto-style2 {
            position: absolute;
            top: 156px;
            left: 61px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 212px;
            left: 160px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 213px;
            left: 217px;
            z-index: 1;
            width: 30px;
        }
        .auto-style5 {
            position: absolute;
            top: 188px;
            left: 69px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtCustomer" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:Label ID="lblCustomerAccount" runat="server" CssClass="auto-style2" Text="Are you sure you want to delete this customer account?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style3" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style4" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <body bgcolor="powderblue">
    </form>
</body>
</html>
