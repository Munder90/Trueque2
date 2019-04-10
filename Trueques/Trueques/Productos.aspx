<%@ Page Title="Datos del Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Trueques.Productos" %>

<asp:Content ID="Productos" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row">

        <%--<h3 style="background-color: lightgray; width:1200px; height:50px; text-align:center; font-size:large;">DATOS DEL PRODUCTO</h3>
        <form action="Producto/Producto" method="post">--%>
        <%--<div class="card-panel">
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"  Text="ID:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text_ID" runat="server"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label2" runat="server"  Text="Nombre del producto:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text_nombre" runat="server"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label3" runat="server"  Text="Etiqueta:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Text_Etiqueta" runat="server"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label4" runat="server"  Text="Categoria del Producto:&nbsp;"></asp:Label>
            &nbsp;
            <asp:TextBox ID="Text_Categoria" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btn_cargar" runat="server" Text="Cargar Producto" BackColor="#999999" ForeColor="Black" />--%>
            <%--<label style="padding-right: initial;">ID: <input  style="margin-left:20px;" type="text" name="id" value=""/></label>
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
            <br />--%>
            <%--<asp:Button ID="cargar" runat="server" OnClick="registrarse_Click" Text="Cargar Producto" BackColor="#999999" ForeColor="Black" />--%>
            <%--<input type="submit" name="Cargar producto" value="Cargar" />--%>
        <%--</div>--%>
        <%--</form>--%>
        <div class="card-panel">
        <%--<form action="Producto/EliminarProducto" method="post">--%>
            <asp:Button ID="btn_nuevo" OnClick="Nuevo_Click" runat="server" Text="Nuevo" BackColor="#999999" ForeColor="Black" />
            <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" BackColor="#999999" ForeColor="Black" />
            <%--<a class="waves-effect waves-light btn m-b-xs" href="Nuevo"><i class="material-icons left">add</i>&nbsp;&nbsp;Nuevo</a>
            <a class="waves-effect waves-light btn m-b-xs" href="Eliminar"><i class="material-icons left">trash</i>&nbsp;&nbsp;Eliminar</a>--%>
            <%--<input type="submit" name="EliminarProducto" value="Eliminar" />--%>
        <%--</form>--%>
            <%--<asp:Button ID="Button1" runat="server" Text="Eliminar" BackColor="#999999" ForeColor="Black" />--%>
            <%--<input type="button" name="ConsultarProductos" value="Listar" />--%>
        </div>
        <br />
        <br />
        <%--<table height="100%" cellspacing="0" cellpadding="0" width="100%">
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
        </table>--%>
        
        <asp:GridView ID="grid_productos" runat="server" AutoGenerateColumns="false">
            <Columns>

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
