<%@ Page Title="Nuevo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.cs" Inherits="Trueques.Producto" %>

<asp:Content ID="Nuevo" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <%--<h2>Producto agregado con éxito</h2>--%>
    <div class="row">
        <div class="card-panel">
            <h4 class="text-center">Mi articulo</h4>
            <br />
            <div class="row" id="div_tengo">
                <%--&nbsp;&nbsp;<asp:Label ID="Label1" runat="server"  Text="ID:&nbsp;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Text_ID" runat="server"></asp:TextBox>
                <br /><br />--%>
                &nbsp;&nbsp;<asp:Label ID="Label2" runat="server"  Text="Nombre del producto:&nbsp;"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Text_nombre_t" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo nombre es obligatorio" ControlToValidate="Text_nombre_t" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />
                &nbsp;&nbsp;<asp:Label ID="Label3" runat="server"  Text="Etiqueta:&nbsp;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Text_Etiqueta_t" runat="server" Style="text-transform: uppercase"></asp:TextBox>
                <br /><br />
                &nbsp;&nbsp;<asp:Label ID="Label4" runat="server"  Text="Categoria del Producto:&nbsp;"></asp:Label>
                &nbsp;
                <asp:TextBox ID="Text_Categoria_t" runat="server" Style="text-transform: uppercase"></asp:TextBox>
                <br /><br />
                &nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Imagen:&nbsp;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUpload1" runat="server" Width="368px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Selecciona una imagen" ControlToValidate="FileUpload1" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
            </div>
            <hr style="color: #393D46;" />
            <h4 class="text-center">Lo que busco</h4>
            <br />
            <div class="row" id="div_busco">
                <div class="col-xs-4 col-sm-4 col-md-4" id="div_busco1">
                    <h4 class="text-center">Opcion 1</h4>
                    &nbsp;&nbsp;<asp:Label ID="Label6" runat="server"  Text="Nombre del producto:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Ingresa al menos un producto que busques" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label7" runat="server"  Text="Etiqueta:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Style="text-transform: uppercase"></asp:TextBox>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Imagen 1&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUpload2" runat="server" Width="368px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Selecciona una imagen" ControlToValidate="FileUpload2" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="col-xs-4 col-sm-4 col-md-4" id="div_busco2">
                    <h4 class="text-center">Opcion 2</h4>
                    &nbsp;&nbsp;<asp:Label ID="Label9" runat="server"  Text="Nombre del producto:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label10" runat="server"  Text="Etiqueta:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Style="text-transform: uppercase"></asp:TextBox>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text="Imagen 1&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUpload3" runat="server" Width="368px" />
                </div>
                <div class="col-xs-4 col-sm-4 col-md-4" id="div_busco3">
                    <h4 class="text-center">Opcion 3</h4>
                    &nbsp;&nbsp;<asp:Label ID="Label12" runat="server"  Text="Nombre del producto:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label13" runat="server"  Text="Etiqueta:&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server" Style="text-transform: uppercase"></asp:TextBox>
                    <br /><br />
                    &nbsp;&nbsp;<asp:Label ID="Label14" runat="server" Text="Imagen 1&nbsp;"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUpload4" runat="server" Width="368px" />
                </div>
            </div>
            <br /><br />
            <asp:Button ID="btn_cargar" runat="server" Text="Guardar" OnClick="Cargar_Click" BackColor="#999999" ForeColor="Black" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" BackColor="#999999" ForeColor="Black" CausesValidation="false" />
        </div>
    </div>
</asp:Content>
