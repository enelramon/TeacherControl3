<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true"
    CodeBehind="RegistroTareas.aspx.cs" 
    Inherits="TeacherControl3.Registros.RegistroTareas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4">
                    <asp:Label ID="registrotareasLabel" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Registro Tareas"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="mensajeLabel" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                </td>
            </tr>
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
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CodigotareaTextBox" ErrorMessage="Debe de poner l menos un codigo" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha</td>
                <td class="auto-style3">
                    <asp:TextBox ID="FechaTextBox" runat="server" TextMode="Date" Width="247px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Vence</td>
                <td class="auto-style3">
                    <asp:TextBox ID="VenseTextBox" runat="server" Height="27px" TextMode="Date" Width="247px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Semestre</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="IdsemestreDropDownList" runat="server" Height="30px" Width="259px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="IdsemestreDropDownList" ErrorMessage="Debe Elegir un semestre" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;Asignatura</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="IdasignaturaDropDownList" runat="server" Height="58px" Width="256px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="IdasignaturaDropDownList" ErrorMessage="Debe Elegir  una asignatura" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Descripcion</td>
                <td class="auto-style3" colspan="2">
                    <asp:TextBox ID="DescripcionTextBox" runat="server" Height="114px" TextMode="MultiLine" Width="369px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="IdsemestreDropDownList" ErrorMessage="Debe poner una descripcion" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="NuevoButton" runat="server" Font-Size="Large" Height="40px" OnClick="NuevoButton_Click" Text="Nuevo" Width="110px" />
                </td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="GuardarButton" runat="server" Font-Size="Large" Height="37px" OnClick="GuardarButton_Click" Text="Guardar" Width="118px" />
                    &nbsp;</td>
                <td>
                    <asp:Button ID="EliminarButton" runat="server" Font-Size="Large" Height="38px" OnClick="EliminarButton_Click" Text="Eliminar" Width="118px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>
