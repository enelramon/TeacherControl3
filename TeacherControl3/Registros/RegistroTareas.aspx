<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroTareas.aspx.cs" Inherits="TeacherControl3.RegistroTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 105px;
        }
        .auto-style3 {
            width: 209px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">IdTarea</td>
                <td class="auto-style3">
                    <asp:TextBox ID="IdtareaTextBox" runat="server" Width="172px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">CodigoTarea</td>
                <td class="auto-style3">
                    <asp:TextBox ID="CodigotareaTextBox" runat="server" Width="168px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha</td>
                <td class="auto-style3">
                    <asp:TextBox ID="FechaTextBox" runat="server" Width="165px" TextMode="Date"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Vense</td>
                <td class="auto-style3">
                    <asp:TextBox ID="VenseTextBox" runat="server" Width="162px" TextMode="Date"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">IdSemestre</td>
                <td class="auto-style3">
                    <asp:TextBox ID="IdsemestreTextBox" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">IdAsignatura</td>
                <td class="auto-style3">
                    <asp:TextBox ID="IdasignaturaTextBox" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">IdSeccion</td>
                <td class="auto-style3">
                    <asp:TextBox ID="IdseccionTextBox" runat="server" Width="159px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Descripcion</td>
                <td class="auto-style3">
                    <asp:TextBox ID="DescripcionTextBox" runat="server" Width="155px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="NuevoButton" runat="server" Height="40px" Text="Nuevo" Width="110px" />
                </td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="GuardarButton" runat="server" Height="37px" Text="Guardar" Width="118px" />
                </td>
                <td>
                    <asp:Button ID="EliminarButton" runat="server" Height="38px" Text="Eliminar" Width="118px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
