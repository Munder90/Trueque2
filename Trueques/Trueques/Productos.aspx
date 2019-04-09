<%@ Page Title="Datos del Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Trueques.Productos" %>

<asp:Content ID="Productos" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row">

        <%--<h3 style="background-color: lightgray; width:1200px; height:50px; text-align:center; font-size:large;">DATOS DEL PRODUCTO</h3>
        <form action="Producto/Producto" method="post">--%>
        <div class="card-panel">
            <label style="padding-right: initial;">ID: <input  style="margin-left:20px;" type="text" name="id" value=""/></label>
            <br />
            <br />
            <label style="padding-right:initial;">Nombre del producto: <input style="margin-left:20px;" type="text" name="nombreprod" value=" " /></label>
            <br />
            <br />
            <label>Etiqueta:<input style="table-layout; margin-left:45px;" type="text" name="etiqueta" value=" " /></label>
            <br />
            <br />
            <label> Categoria del Producto: <select>
                <option>E</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
                <option>6</option>
            </select></label>
            <br />
            <br />
            <label>Descripción breve: <input style="table-layout; margin-left:45px;" type="text" name="descripcion" value=" "</label>
            <br />
            <br />
            <label>Imagen 1: <input type="file" name="img1" value=" "</label>
            <br />
            <br />
            <label>Imagen 2: <input type="file" name="img2" value=" "</label>
            <br />
            <br />
            <label>Imagen 3: <input type="file" name="img3" value=" "</label>
            <br />
            <br />
            <input type="submit" name="Cargar producto" value="Cargar" />
        </div>
        <%--</form>--%>
        <div class="row">
        <%--<form action="Producto/EliminarProducto" method="post">--%>
            <input type="submit" name="EliminarProducto" value="Eliminar" />
        <%--</form>--%>
        </div>
        <input type="button" name="ConsultarProductos" value="Listar" />
        <br />
        <br />
        <table height="100%" cellspacing="0" cellpadding="0" width="100%">
            <thead>
                <tr>ID</tr>
                <tr>Producto</tr>
                <tr>Entiqueta</tr>
                <tr>Categoria</tr>
                <tr>Descripcion</tr>
                <tr>Imagen 1</tr>
                <tr>Imagen 2</tr>
                <tr>Imagen 3</tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</asp:Content>
