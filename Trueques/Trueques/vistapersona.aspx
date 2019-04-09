<%@ Page Title="vistapersona" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistapersona.aspx.cs" Inherits="Trueques.vistapersona" %>

<asp:Content ID="vistapersona" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row">
        <label>Nombre del producto: @Model.nombreprod <br /></label>
        <label>Tipo de producto: @Model.tipoprod <br/></label>
        <label>Descripción breve: @Model.descprod <br/></label>
        <label>Imagen 1<br/></label>
        <label>Imagen 2<br/></label>
        <label>Imagen 3<br/></label>
    </div>
</asp:Content>
