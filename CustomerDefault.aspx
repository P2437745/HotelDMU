<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDefault.aspx.cs" Inherits="CustomerDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            position: absolute;
            top: 308px;
            left: 334px;
            z-index: 1;
            width: 188px;
            height: 20px;
        }
        .auto-style3 {
            position: absolute;
            top: 420px;
            left: 356px;
            z-index: 1;
            right: 1158px;
        }
        .auto-style4 {
            position: absolute;
            top: 467px;
            left: 357px;
            z-index: 1;
            }
        .auto-style5 {
            position: absolute;
            top: 507px;
            left: 351px;
            z-index: 1;
            height: 26px;
        }
        .auto-style6 {
            position: absolute;
            top: 362px;
            left: 338px;
            z-index: 1;
            height: 20px;
        }
        .auto-style7 {
            position: absolute;
            top: 305px;
            left: 577px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 303px;
            left: 689px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:TextBox ID="txtCustomers" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style3" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style4" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style5" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDispalyAll" runat="server" CssClass="auto-style8" Text="Display All" OnClick="btnDispalyAll_Click" />
        <asp:ListBox ID="ListBoxCustomers" runat="server" style="z-index: 1; left: 319px; top: 96px; position: absolute; height: 165px; width: 379px"></asp:ListBox>
        <body bgcolor="powderblue">
    </form>
</body>
 
    </style>
</head>
</html>


