<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true"
     CodeBehind="registroSemestres.aspx.cs"
     Inherits="TeacherControl3.Registros.registroSemestres" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Id Semestre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IdSemestresTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Codigo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="CodigoTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Inicio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaInicioTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Fin&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaFinTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Parcial1&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaParcial1TextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Parcial2&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaParcial2TextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha Final&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaFinalTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:CheckBox ID="esActivoCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="activo" />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
&nbsp;&nbsp;
        <asp:Button ID="ClearButton" runat="server" Text="Clear" />
&nbsp;&nbsp;
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" />
    </p>
</asp:Content>
