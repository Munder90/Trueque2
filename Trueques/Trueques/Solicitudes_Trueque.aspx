<%@ Page Title="Trueque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Solicitudes_Trueque.aspx.cs" Inherits="Trueques.Solicitudes_Trueque" %>

<asp:Content ID="Solicitudes_Trueque" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row">
        <div class="card-panel">
            <br /><br />
            <h3 class="text-center">Solicitudes de Trueque</h3>

            <div class="col-xs-6 col-sm-6 col-md-6" id="div_buscan">
                <h2 class="text-center">Recibidas</h2>
                <asp:GridView ID="grid_buscan1" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="ApodoUser" HeaderText="Usuario" />
                        <asp:BoundField DataField="ProductoBuscas" HeaderText="Nombre Producto" />
                        <asp:ImageField DataImageUrlField="ImagenBuscas" HeaderText="Imagen"></asp:ImageField>
                        <asp:BoundField DataField="ProductoTienen" HeaderText="Nombre Producto" />
                        <asp:ImageField DataImageUrlField="ImagenTienen" HeaderText="Imagen"></asp:ImageField>
                        <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
                        <asp:ButtonField ButtonType="Button" text="En Espera" CommandName="Espera" />
                        <asp:ButtonField ButtonType="Button" text="Aceptar" CommandName="Aceptar" />
                        <asp:ButtonField ButtonType="Button" text="Rechazar" CommandName="Rechazar" />
                    </Columns>
                </asp:GridView>
                <%--<table id="table_buscan">
                </table>--%>
            </div>

            <div class="col-xs-6 col-sm-6 col-md-6" id="div_tienen">
                <h2 class="text-center">Enviadas</h2>
                <asp:GridView ID="grid_tienen1" runat="server" AutoGenerateColumns="false">

                </asp:GridView>
                <%--<table id="table_tienen">
                </table>--%>
            </div>
        </div>
    </div>
</asp:Content>