<%@ Page Title="Trueque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trueques._Default" %>

<asp:Content ID="Home" ContentPlaceHolderID="MainContent" runat="server">
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
                <div class="col-xs-6 col-sm-6 col-md-6" id="div_buscan">
                    <h2 class="text-center">Buscan</h2>
                    <table id="table_buscan">
                    </table>
                </div>
                <div class="col-xs-6 col-sm-6 col-md-6" id="div_tienen">
                    <h2 class="text-center">Tienen</h2>
                    <table id="table_tienen">
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
