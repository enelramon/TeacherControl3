<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="cSemestres.aspx.cs" Inherits="TeacherControl3.Consultas.cSemestres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 142px;
        }
        .auto-style3 {
            width: 431px;
        }
        .auto-style4 {
            width: 142px;
            height: 78px;
        }
        .auto-style5 {
            width: 431px;
            height: 78px;
        }
        .auto-style6 {
            height: 78px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="MyUpdatePanel" runat="server">
        <ContentTemplate>
              <p>
                  <table style="width:100%; height: 646px;">
                      <tr>
                          <td class="auto-style2">&nbsp;</td>
                          <td class="auto-style3">
                              <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#000099" Text="Consulta de Semestres"></asp:Label>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td class="auto-style4">&nbsp;&nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
                          </td>
                          <td class="auto-style5">Buscar:&nbsp;<asp:DropDownList ID="BuscarDropDownList" runat="server" Width="112px">
                              <asp:ListItem>Id</asp:ListItem>
                              <asp:ListItem>Codigo</asp:ListItem>
                              </asp:DropDownList>
                              <asp:TextBox ID="BuscarTextBox" runat="server"></asp:TextBox>
                              <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar" />
                          </td>
                          <td class="auto-style6"></td>
                      </tr>
                      <tr>
                          <td colspan="3">
                          </td>
                      </tr>
                      <tr>
                          <td colspan="3">
                              <asp:GridView ID="BuscarGridView" runat="server">
                                  <Columns>
                                      <asp:HyperLinkField DataNavigateUrlFields="IdSemestre" DataNavigateUrlFormatString="~/Registros/rSemestres.aspx?IdSemestre={0}" Text="Editar" />
                                      <asp:HyperLinkField DataNavigateUrlFields="IdSemestre" DataNavigateUrlFormatString="~/Registros/rSemestres.aspx" Text="Nuevo" />
                                  </Columns>
                              </asp:GridView>
                          </td>
                      </tr>
                  </table>
                  <hr />
                  <p>
                  </p>
                  <p>
                  </p>
                  <p>
                  </p>
    </p>
            </ContentTemplate>
    </asp:UpdatePanel>
  
</asp:Content>
