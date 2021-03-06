﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroAsignatura.aspx.cs" Inherits="TeacherControl3.Registros.RegistroAsignatura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style3 {
        }
        .auto-style4 {
            width: 84px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    </div>
    <table>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="IdAsignatura" runat="server" Text="IdAsignatura"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="IdAsignaturaTextBox" runat="server" style="margin-left: 0px" Width="70px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="CodigoLabel" runat="server" Text="Codigo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CodigoTextBox" runat="server" Width="70px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="NombreLabel" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NombreTextBox" runat="server" Width="147px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NombreTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="Red">El campo &quot; Nombre &quot; no puede estar vacio.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="CreditosLabel" runat="server" Text="Creditos"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="CreditosTextBox" runat="server" Width="70px"></asp:TextBox>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="Activo" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="EliminarButton" runat="server" OnClick="EliminarButton_Click" Text="Eliminar " />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="GuardarButton" runat="server" Height="32px" OnClick="GuardarButton_Click" Text="Guardar" Width="82px" />
                &nbsp;
            </td>
        </tr>
        </table>
    </asp:Content>
