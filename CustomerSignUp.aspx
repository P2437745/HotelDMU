<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSignUp.aspx.cs" Inherits="CustomerSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 90px;
            left: 73px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 134px;
            left: 71px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 175px;
            left: 71px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 219px;
            left: 71px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 260px;
            left: 68px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 306px;
            left: 67px;
            z-index: 1;
            height: 19px;
        }
        .auto-style7 {
            position: absolute;
            top: 87px;
            left: 202px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 130px;
            left: 201px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 175px;
            left: 200px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 217px;
            left: 198px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 262px;
            left: 196px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 303px;
            left: 194px;
            z-index: 1;
            right: 1188px;
        }
        .auto-style13 {
            position: absolute;
            top: 386px;
            left: 271px;
            z-index: 1;
            height: 26px;
        }
        .auto-style14 {
            position: absolute;
            top: 387px;
            left: 351px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 45px;
            left: 74px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 51px;
            left: 205px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style1" Text="First Name"></asp:Label>
        <asp:Label ID="lblSureName" runat="server" CssClass="auto-style2" Text="Sure Name"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" CssClass="auto-style3" Text="Address"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style4" Text="Email"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" CssClass="auto-style5" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblDateOfBirth" runat="server" CssClass="auto-style6" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:TextBox ID="txtSureName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtDateOfBirth" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style13" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style14" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="txtCustomerID" runat="server" CssClass="auto-style15" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" CssClass="auto-style16"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 109px; top: 361px; position: absolute" Text="[lblError]"></asp:Label>
        <body bgcolor="powderblue">
    </form>
</body>
</html>
