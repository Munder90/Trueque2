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
            <div class="col-xs-6 col-sm-6 col-md-6" id="div_buscan">
                <h2 class="text-center">Buscan</h2>
                <%--<asp:SqlDataSource id="buscan" runat="server"
                    connectionString="Data Source=SF-0011;Initial Catalog=TRK;Integrated Security=True"
                    providerName="System.Data.SqlClient"
                    SelectCommand="SELECT [imgProductoB] FROM Producto_B ORDER BY id DESC limit 10">
                </asp:SqlDataSource>--%>
                <asp:GridView ID="grid_buscan" runat="server" AutoGenerateColumns="false">
                    
                </asp:GridView>
                <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image3" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image4" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image5" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image6" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image7" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image8" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image9" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image10" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image11" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image12" runat="server" Height="150px" Width="150px" /><br />

               <%-- <table id="table_buscan">
                </table>--%>
            </div>
            <div class="col-xs-6 col-sm-6 col-md-6 " id="div_tienen">
                <h2 class="text-center">Tienen</h2>
                <asp:GridView ID="grid_tienen" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        
                    </Columns>
                </asp:GridView>
                <asp:Image ID="Image13" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image14" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image15" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image16" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image17" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image18" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image19" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image20" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image21" runat="server" Height="150px" Width="150px" /><br />
                <asp:Image ID="Image22" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image23" runat="server" Height="150px" Width="150px" />
                <asp:Image ID="Image24" runat="server" Height="150px" Width="150px" /><br />
                <%--<table id="table_tienen">
                </table>--%>
            </div>
        </div>
    </div>
</asp:Content>
