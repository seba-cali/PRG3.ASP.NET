<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="ejemplo1.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
			<h1>Ejemplo con Master</h1>
			
			<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
			<asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
			<asp:Label Text="" ID="lblsaludo" runat="server" />


			<a href ="About">DESCRIPCION</a>



</asp:Content>
