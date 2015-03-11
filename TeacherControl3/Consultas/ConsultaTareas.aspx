<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaTareas.aspx.cs" Inherits="TeacherControl3.Consultas.ConsultaTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="4">&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Consulta Tareas"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Buscar</td>
            <td class="auto-style3">
                <asp:DropDownList ID="buscarDropDownList" runat="server" Width="152px">
                    <asp:ListItem>Codigo Tarea</asp:ListItem>
                    <asp:ListItem>Descripcion</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="buscarTextBox" runat="server" Width="217px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="buscarButton" runat="server" Font-Bold="True" Font-Size="Large" Height="35px" OnClick="buscarButton_Click" Text="Buscar" Width="96px" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="consultatareasGridView" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
