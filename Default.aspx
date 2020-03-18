<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 25px;
            top: 68px;
            position: absolute;
            height: 241px;
            width: 303px;
        }
        .auto-style2 {
            z-index: 1;
            left: 29px;
            top: 315px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 29px;
            top: 349px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 20px;
            top: 469px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 133px;
            top: 467px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 74px;
            top: 468px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 14px;
            top: 392px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 90px;
            top: 393px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 22px;
            top: 436px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblerror" runat="server" CssClass="auto-style9" Text="[ERROR]"></asp:Label>
        </div>
        <asp:ListBox ID="lstRoomtype" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblFilter" runat="server" CssClass="auto-style2" Text="Please enter a roomtype "></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" CssClass="auto-style3"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style4" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style5" OnClick="Button2_Click" Text="Delete " />
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" Text="Apply " OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplay" runat="server" CssClass="auto-style8" Text="Display All " OnClick="btnDisplay_Click" />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style6" Text="Edit " OnClick="Button3_Click1" />
    </form>
</body>
</html>
