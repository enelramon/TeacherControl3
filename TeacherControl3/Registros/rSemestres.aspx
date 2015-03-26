<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="rSemestres.aspx.cs"
    Inherits="TeacherControl3.Registros.rSemestres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 166px;
        }
        .auto-style3 {
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registro de Semestres</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;
        <asp:Label ID="CodigoLabel0" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="ID" Visible="False"></asp:Label>
                  
                <td class="auto-style2">
                    <asp:TextBox ID="IdSemestreTextBox" runat="server" Visible="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="CodigoLabel" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Codigo"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="CodigoTextBox" runat="server" Width="142px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CodigoTextBox" ErrorMessage="* Debe introducir el codigo" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="FechaInicio" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha de Inicio"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaInicioTextBox" runat="server" TextMode="Date" Width="153px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FechaInicioTextBox" ErrorMessage="* Debe introducir la fecha de inicio" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="FechaFin0" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha Fin"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaFinTextBox" runat="server" TextMode="Date" Width="153px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FechaFinTextBox" ErrorMessage="* Debe introducir la fecha del fin de semestre" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="FechaParcial1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha del 1er Parcial"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaParcial1TextBox" runat="server" TextMode="Date" Width="142px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FechaParcial1TextBox" ErrorMessage="* Debe introducir la fecha del 1er parcial" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="FechaParcial2" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha del 2do Parcial"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaParcial2TextBox" runat="server" TextMode="Date" Width="149px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FechaParcial2TextBox" ErrorMessage="* Debe introducir la fecha del 2do parcial" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="FechaFinal" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha para el Final"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="FechaFinalTextBox" runat="server" TextMode="Date" Width="159px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="FechaFinalTextBox" ErrorMessage="* Debe introducir la fecha para el final" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>

                <td class="auto-style2">
                    <asp:CheckBox ID="esActivoCheckBox" runat="server" BackColor="Silver" Font-Bold="True" ForeColor="#000099" Text="Activo" OnCheckedChanged="esActivoCheckBox_CheckedChanged" Checked="True" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
                    <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
                    <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
    
</asp:Content>
