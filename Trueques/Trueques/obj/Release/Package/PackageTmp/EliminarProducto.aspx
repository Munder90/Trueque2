<%@ Page Title="Producto eliminado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="Trueques.EliminarProducto" %>

<asp:Content ID="EliminarProducto" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row"> 
        <h1 class="text-center">Producto eliminado correctamente</h1>
    </div>
    <div class="row">
        <asp:Label ID="Label1" runat="server"  Text="Producto:&nbsp;&nbsp;"></asp:Label>
        <asp:Label ID="Label2" runat="server"  Text=""></asp:Label>
    </div>
</asp:Content>
