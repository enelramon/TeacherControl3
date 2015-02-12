<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaEvaluacion.aspx.cs" Inherits="TeacherControl3.ConsultaEvaluacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 393px;
        }
        .auto-style2 {
            width: 177px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="112px">
                        <asp:ListItem>Id</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:GridView ID="GridView1" runat="server" Height="177px" Width="326px">
                    </asp:GridView>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
