<%@ Page Title="Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Trueques.Producto" %>

<asp:Content ID="Producto" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <%--<h2>Producto agregado con éxito</h2>--%>
    <div class="row">
        <label>Nombre del producto: @Model.nombreprod</label><br />
        <label>Tipo de producto: @Model.tipoprod</label><br />
        <label>Descripción breve: @Model.descprod</label><br />
        <label>Imagen 1: @Model.img1</label><br />
        <label>Imagen 2: @Model.img2</label><br />
        <label>Imagen 3: @Model.img3</label><br />
    </div>
</asp:Content>
