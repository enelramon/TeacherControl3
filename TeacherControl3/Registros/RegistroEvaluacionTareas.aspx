<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEvaluacionTareas.aspx.cs" Inherits="TeacherControl3.Registros.RegistroEvaluacionTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
        .auto-style2 {
            width: 150px;
            height: 39px;
        }
        .auto-style3 {
            height: 39px;
            width: 431px;
        }
        .auto-style4 {
            width: 431px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 98%; height: 61px;">
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label1" runat="server" Text="IdEvaluacion"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="IdEvaluacionTextBox" runat="server" Height="29px" Width="427px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label6" runat="server" Text="IdTarea"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="IdTareaTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label2" runat="server" Text="IdEstudiante"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="IdEstudianteTextBox" runat="server" Height="29px" Width="427px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label4" runat="server" Text="Calificacion"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="CalificacionTextBox" runat="server" Height="29px" Width="427px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:TextBox ID="IdTareaTextBox0" runat="server" Height="103px" Width="356px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="FechaTextBox" runat="server" Height="16px" Width="162px">  DD-MM-YYYY</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" Width="137px" />
            </td>
            <td class="auto-style4">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" Width="143px" />
                &nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click1" />
                &nbsp;&nbsp;
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" Width="133px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
    </table>
</asp:Content>
