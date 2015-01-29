<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEstudiantes.aspx.cs" Inherits="TeacherControl3.Registros.RegistroEstudiantes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 101%; height: 283px;">
        <tr>
            <td class="auto-style3" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTRO ESTUDIANTES&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="IdLabel" runat="server" Text="Id"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="IdRegistroTextBox" runat="server" Width="56px" BackColor="#006699"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Nombreslabel" runat="server" Text="Nombres          "></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="NombresTextBox" runat="server" Width="152px" BackColor="#006699"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NombresTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="#00CC00">El campo &quot; Nombres &quot; no puede estar vacio.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="ApellidosLabel" runat="server" Text="Apellidos"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="ApellidosTextBox" runat="server" Width="152px" BackColor="#006699"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ApellidosValidator" runat="server" ControlToValidate="ApellidosTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="#00CC00">El campo &quot; Apellidos &quot; no puede estar vacio.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="TelefonoLabel" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="TelefonoTextBox" runat="server" Width="152px" BackColor="#006699"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TelefonoValidator" runat="server" ControlToValidate="TelefonoTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="#00CC00">El campo &quot; Telefono &quot; esta incompleto.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="CelularLabel" runat="server" Text="Celular"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="CelularTextBox" runat="server" Width="152px" BackColor="#006699"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CelularValidator" runat="server" ControlToValidate="CelularTextBox" ErrorMessage="RequiredFieldValidator" ForeColor="#00CC00">El campo &quot; Celular &quot; esta incompleto.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="FechaLabel" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="FechaTextBox" runat="server" Width="152px" BackColor="#006699" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="DireccionLabel" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="DireccionTextBox" runat="server" Width="231px" BackColor="#006699"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:TextBox ID="EmailTextBox" runat="server" Width="231px" BackColor="#006699"></asp:TextBox>
                <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="RegularExpressionValidator" ForeColor="#00CC00" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">El campo &quot; Email &quot; esta incorrecto.</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" ForeColor="#0000CC" Width="44px" />
                &nbsp;
                <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" ForeColor="#000099" />
                &nbsp;
        <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" ForeColor="#0000CC" />
            </td>
        </tr>
    </table>
</asp:Content>
