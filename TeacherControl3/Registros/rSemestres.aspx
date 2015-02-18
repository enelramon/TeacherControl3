<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rSemestres.aspx.cs" Inherits="TeacherControl3.Registros.rSemestres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Registro de Semestres&nbsp;&nbsp;
        <asp:Label ID="CodigoLabel0" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="ID"></asp:Label>
        :
        <asp:TextBox ID="IdSemestreTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CodigoLabel" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Codigo"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="CodigoTextBox" runat="server" Width="142px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;<asp:Label ID="FechaInicio" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha de Inicio"></asp:Label>
        :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="FechaInicioTextBox" runat="server" TextMode="Date" Width="153px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Label ID="FechaFin0" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha Fin"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="FechaFinTextBox" runat="server" TextMode="Date" Width="153px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="FechaParcial1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha del 1er Parcial"></asp:Label>
        :&nbsp;&nbsp;
        <asp:TextBox ID="FechaParcial1TextBox" runat="server" TextMode="Date" Width="142px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Label ID="FechaParcial2" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha del 2do Parcial"></asp:Label>
        :&nbsp;&nbsp;
        <asp:TextBox ID="FechaParcial2TextBox" runat="server" TextMode="Date" Width="149px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Label ID="FechaFinal" runat="server" BackColor="#CCCCCC" BorderColor="#999999" Font-Bold="True" ForeColor="#000099" Text="Fecha para el Final"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="FechaFinalTextBox" runat="server" TextMode="Date" Width="159px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="esActivoCheckBox" runat="server" BackColor="Silver" Font-Bold="True" ForeColor="#000099" Text="Activo" OnCheckedChanged="esActivoCheckBox_CheckedChanged" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
        <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
    </p>
</asp:Content>
