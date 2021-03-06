﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rUsuarios.aspx.cs" Inherits="TeacherControl3.Registros.rUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 194px;
        }
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            width: 194px;
            height: 51px;
        }
        .auto-style4 {
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                     ControlToValidate="IdTextBox"
                     ErrorMessage="Introdusca un Id valido"
                     ForeColor="Red"
                     SetFocusOnError="true">*
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="NombreLabel" runat="server" Text="Nombre" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="NombreTextBox" runat="server" Width="232px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="NombreTextBox" 
                    ErrorMessage="Introdusca un Nombre valido"
                    ForeColor="Red"
                    SetFocusOnError="true">*
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="ClaveLabel" runat="server" Text="Clave" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="ClaveTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                     ControlToValidate="ClaveTextBox"
                     ErrorMessage="Introdusca una Clave Valida"
                     ForeColor="Red"
                     SetFocusOnError="true">*
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="ConfirmarLabel" runat="server" ForeColor="Black" Text="Confirmar Clave"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="ConfirmarTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                     ControlToValidate="ConfirmarTextBox"
                     ErrorMessage="Introdusca de nuevo la Clave "
                     ForeColor="Red"
                     SetFocusOnError="true">*
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server"
                     ControlToCompare="ClaveTextBox" ControlToValidate="ConfirmarTextBox"
                     ErrorMessage="La clave es incorrecta introduscala de nuevo"
                     ForeColor="Red"
                     SetFocusOnError="true">* </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="EmailLabel" runat="server" Text="Email" ForeColor="Black"></asp:Label>
            </td>
            <td colspan="2" class="auto-style4">
                <asp:TextBox ID="EmailTextBox" runat="server" Width="231px"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" runat="server"
                     ControlToValidate="EmailTextBox"
                     ErrorMessage="Introdusca un Email valido"
                     ForeColor="Red"
                     ValidateEmptyText="True">*
                </asp:CustomValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="EmailTextBox" 
                    ErrorMessage="Escriba un Email valido" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td colspan="2">
                <asp:CheckBox ID="esActivoCheckBox" runat="server" OnCheckedChanged="esActivoCheckBox_CheckedChanged" />
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

</asp:Content>
