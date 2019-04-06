<%@ Page Title="Trueque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Solicitudes_Trueque.aspx.cs" Inherits="Trueques.Solicitudes_Trueque" %>

<asp:Content ID="Solicitudes_Trueque" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel text-center">
            <h1>T R K</h1>
            <h3>Se tiene lo que se quiere</h3>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="card-panel">
            <div class="row">
                <br /><br />
                <h4 class="text-center">Solicitudes de Trueque</h4>
                <div class="col-xs-6 col-sm-6 col-md-6" id="div_buscan">
                    <h2 class="text-center">Recibidas</h2>
                    <table id="table_buscan">
                    </table>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-6" id="div_tienen">
                    <h2 class="text-center">Enviadas</h2>
                    <table id="table_tienen">
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>