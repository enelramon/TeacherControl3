<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sumar.aspx.cs" Inherits="TeacherControl3.Registros.sumar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="Num1TextBox" runat="server"></asp:TextBox>
            +<asp:TextBox ID="Num2TextBox" runat="server"></asp:TextBox>
            &nbsp;=<asp:Label ID="TotalLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="SumarButton" runat="server" OnClick="SumarButton_Click" Text="Button" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
</asp:Content>
