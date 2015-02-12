<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="TeacherControl3.Consultas.ConsultaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" colspan="4">
                <asp:Label ID="ConsultaUsuarioLabel" runat="server" Font-Bold="True" ForeColor="Black" Text="Consulta de Usuario"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="BuscarLabel" runat="server" ForeColor="Black" Text="Buscar:"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:ListBox ID="BuscarListBox" runat="server" Height="25px" OnSelectedIndexChanged="BuscarListBox_SelectedIndexChanged">
                    <asp:ListItem>Id</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                </asp:ListBox>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="BuscarTextBox" runat="server" Width="181px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="BuscarButton" runat="server" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="4">
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdUsuario" Text="Edit" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
