<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="cSemestres.aspx.cs" Inherits="TeacherControl3.Consultas.cSemestres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
        <ContentTemplate>
              <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#000099" Text="Consulta de Semestres"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; Buscar:&nbsp; &nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="112px">
            <asp:ListItem>Id</asp:ListItem>
            <asp:ListItem>Codigo</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="BuscarTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:GridView ID="BuscarGridView" runat="server">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="IdSemestre" DataNavigateUrlFormatString="rSemestres.aspx?IdSemestre={0}" Text="Editar" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
            </ContentTemplate>
    </asp:UpdatePanel>
  
</asp:Content>
