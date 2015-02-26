<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaEvaluaciones.aspx.cs" Inherits="TeacherControl3.ConsultaEvaluaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 662px;
        height: 381px;
    }
    .auto-style4 {
    }
    .auto-style13 {
        width: 86px;
    }
    .auto-style14 {
        height: 38px;
    }
    .auto-style16 {
        width: 541px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
    <tr>
        <td class="auto-style14" colspan="2">&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Consulta de Evaluaciones"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">
            <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>
        </td>
        <td class="auto-style16">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="100px">
                <asp:ListItem>Id</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="113px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Buscar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
