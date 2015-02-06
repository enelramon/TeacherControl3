<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TeacherControl3.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
        <table style="width:100%;">
            <tr>
                <td>Usuario</td>
                <td>
                    <asp:TextBox ID="UsuarioTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Clave</td>
                <td style="font-weight: 700">
                    <asp:TextBox ID="ClaveTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="EntrarButton" runat="server" Text="Entrar" OnClick="EntrarButton_Click" />
                &nbsp;
                    <asp:Button ID="CancelarButton" runat="server" Text="Cancelar" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
 </asp:Content>