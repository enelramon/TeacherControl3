<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true"
    CodeBehind="RegistroTareas.aspx.cs" 
    Inherits="TeacherControl3.Registros.RegistroTareas" %>

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
                    <asp:TextBox ID="IdtareaTextBox" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">CodigoTarea</td>
                <td class="auto-style3">
                    <asp:TextBox ID="CodigotareaTextBox" runat="server" Width="247px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha</td>
                <td class="auto-style3">
                    <asp:TextBox ID="FechaTextBox" runat="server" Width="247px" TextMode="Date"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Vense</td>
                <td class="auto-style3">
                    <asp:TextBox ID="VenseTextBox" runat="server" Width="247px" TextMode="Date"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">IdSemestre</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="IdsemestreDropDownList" runat="server" Height="23px" Width="257px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">IdAsignatura</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="IdasignaturaDropDownList" runat="server" Height="18px" Width="259px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Descripcion</td>
                <td class="auto-style3">
                    <asp:TextBox ID="DescripcionTextBox" runat="server" Width="247px" Height="87px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="NuevoButton" runat="server" Height="40px" Text="Nuevo" Width="110px" OnClick="NuevoButton_Click" />
                </td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="GuardarButton" runat="server" Height="37px" Text="Guardar" Width="118px" OnClick="GuardarButton_Click" />
                </td>
                <td>
                    <asp:Button ID="EliminarButton" runat="server" Height="38px" Text="Eliminar" Width="118px" OnClick="EliminarButton_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
