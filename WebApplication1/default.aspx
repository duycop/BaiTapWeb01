<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">WEB V1: TÍNH DIỆN TÍCH TAM GIÁC
                    </td>
                </tr>
                <tr>
                    <td>Nhập hệ số A:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nhập hệ số B:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nhập hệ số C:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Tính diện tích" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" id="ketqua_web" runat="server"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
