<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="TeacherControl3.RegistroUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 194px;
        }
        .auto-style2 {
            width: 255px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="RuLabel" runat="server" Text="Registro de Usuario" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="Blue"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="IdUsuarioLabel" runat="server" Text="IdUsuario" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="NombreLabel" runat="server" Text="Nombre" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="ClaveLabel" runat="server" Text="Clave" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="ClaveTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="EmailLabel" runat="server" Text="Email" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="esActivoLabel" runat="server" Text="esActivo" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="ActivoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" Width="100px" />
                <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" Width="100px" />
                <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" Width="100px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="MsjLabel" runat="server" Text="MsjLabel"></asp:Label>
                <br />
                <asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" HeaderText="Problema de Resgistro:" />
            </td>
        </tr>
    </table>
</asp:Content>
