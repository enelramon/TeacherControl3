<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEvaluacionTareas.aspx.cs" Inherits="TeacherControl3.Registros.RegistroEvaluacionTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
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
                <asp:Label ID="Label1" runat="server" Text="Evaluacion"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="IdEvaluacionTextBox" runat="server" Height="29px" Width="427px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EvaluacionValidador" runat="server" ControlToValidate="IdEvaluacionTextBox" ErrorMessage="La Evaluacion es Obliagatoria" ForeColor="Red" OnDataBinding="IdEvaluacionTextBox_TextChanged">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label6" runat="server" Text="Tarea"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:DropDownList ID="TareaDropDownList" runat="server" AutoPostBack="True" Width="173px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Tarea 1</asp:ListItem>
                    <asp:ListItem>Tarea 2</asp:ListItem>
                    <asp:ListItem>Tarea 3</asp:ListItem>
                    <asp:ListItem>Tarea 4</asp:ListItem>
                    <asp:ListItem>Tarea 5</asp:ListItem>
                    <asp:ListItem>Tarea 6</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="FechaTextBox" runat="server" Height="16px" Width="162px">  DD-MM-YYYY</asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Fecha Invalidad" ForeColor="Red" OnDataBinding="IdTareaTextBox0_TextChanged" Type="Date">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label2" runat="server" Text="IdEstudiante"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="IdEstudianteTextBox" runat="server" Height="29px" Width="387px" MaxLength="10"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="IdEstudianteTextBox" CultureInvariantValues="True" ErrorMessage="Id Invalido" ForeColor="Red" MaximumValue="15" MinimumValue="6" ValidationGroup="^[a-zA-ZñÑ\s]{2,50}">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="Label4" runat="server" Text="Calificacion"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="CalificacionTextBox" runat="server" Height="29px" Width="383px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="CalificacionTextBox" ErrorMessage="LLenar los Campos Correctamente" ForeColor="Red" MaximumValue="3" MinimumValue="2" ValidationGroup="^[0-9]{2,3}-? ?[0-9]{6,7}$">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'" colspan="2">
                <asp:TextBox ID="IdTareaTextBox0" runat="server" Height="103px" Width="609px" OnTextChanged="IdTareaTextBox0_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="font-family: 'Arial Rounded MT Bold'">
                <asp:Label ID="MensajeLabel" runat="server" ForeColor="Red" Text="Mensaje"></asp:Label>
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
