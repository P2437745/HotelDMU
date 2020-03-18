<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ARoomType.aspx.cs" Inherits="ARoomType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 15px;
            top: 81px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 14px;
            top: 140px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 14px;
            top: 111px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 14px;
            top: 172px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 12px;
            top: 206px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 15px;
            top: 238px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 20px;
            top: 279px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 77px;
            top: 314px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 6px;
            top: 315px;
            position: absolute;
            width: 64px;
        }
        .auto-style10 {
            z-index: 1;
            left: 127px;
            top: 210px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 127px;
            top: 108px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 126px;
            top: 177px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 126px;
            top: 142px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 127px;
            top: 74px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRomId" runat="server" CssClass="auto-style1" Text="Room ID"></asp:Label>
        </div>
        <asp:Label ID="lblRoomSize" runat="server" CssClass="auto-style2" Text="Room Size "></asp:Label>
        <asp:Label ID="lblRoomType" runat="server" CssClass="auto-style4" Text="Room Type"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style5" Text="Date Added "></asp:Label>
        <asp:Label ID="lblRoomFloor" runat="server" CssClass="auto-style3" Text="Room Floor"></asp:Label>
        <asp:CheckBox ID="Active" runat="server" CssClass="auto-style6" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style7" Text="[Error]"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style8" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style9" OnClick="btnOK_Click" Text="OK" />
        <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style10" OnTextChanged="txtDateAdded_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtRoomFloor" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtRoomID" runat="server" CssClass="auto-style14"></asp:TextBox>
        <asp:TextBox ID="txtRoomType" runat="server" CssClass="auto-style12" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtRoomSize" runat="server" CssClass="auto-style13" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
    </form>
</body>
</html>
