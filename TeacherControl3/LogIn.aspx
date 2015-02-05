<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TeacherControl3.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 129px;
        }
        .auto-style2 {
            width: 319px;
        }
        .auto-style3 {
            width: 384px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 36%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="UsuarioLabel" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="UsuarioTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="ClaveLabel" runat="server" Text="Clave"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="ClaveTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="AceptarButton" runat="server" Text="Aceptar" />
                    <asp:Button ID="CancelarButton" runat="server" Text="Cancelar" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
