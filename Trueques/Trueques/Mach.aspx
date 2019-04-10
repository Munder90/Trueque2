<%@ Page Title="Match" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mach.aspx.cs" Inherits="Trueques.Mach" %>
<asp:Content ID="Match" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel">
            <div class="col-xs-6 col-sm-6 col-md-6">
		        <h2 class="text-center">PRODUCTOS SOLICITADOS</h2> 
             </div>
	        <div class="col-xs-6 col-sm-6 col-md-6" >
		        <h2 class="text-center">TUS PRODUCTOS</h2>
	        </div>
		
	        <br />
	        <br />
            <div class="row" style="width: 871px; right: 44px; height: 312px;">
		 
		        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="conexion1" ForeColor="Black" GridLines="Vertical" Height="180px" Width="672px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
			        <AlternatingRowStyle BackColor="White" />
				
			        <Columns>				
				        <asp:BoundField DataField="nombre" HeaderText="Nombre Productos" SortExpression="nombre" />
				        <asp:ImageField DataImageUrlField="imagenTengo" DataImageUrlFormatString="~/Img/{0}" HeaderText="Productos Tienes">
				        </asp:ImageField>
				        <asp:BoundField DataField="nombreBusco" HeaderText="Producto Busco" SortExpression="nombreBusco" />
				        <asp:ImageField DataImageUrlField="imagenBusco" DataImageUrlFormatString="~/Img/{0}" HeaderText="Productos Buscas">
				        </asp:ImageField>
				        <%--<asp:BoundField DataField="descripcion" HeaderText="Descripcion" SortExpression="descripcion" />--%>
                        <asp:ButtonField ButtonType="Button" text="Mach" CommandName="Mach" />
			        </Columns>
			        <FooterStyle BackColor="#CCCC99" />
			        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
			        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
			        <RowStyle BackColor="#F7F7DE" />
			        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
			        <SortedAscendingCellStyle BackColor="#FBFBF2" />
			        <SortedAscendingHeaderStyle BackColor="#848384" />
			        <SortedDescendingCellStyle BackColor="#EAEAD3" />
			        <SortedDescendingHeaderStyle BackColor="#575357" />
		        </asp:GridView>
		        <%--<asp:Button runat="server" Text="MACH" BackColor="#999999" Height="100px" Width="150px" ForeColor="White" ID="btn1" OnClick="Unnamed1_Click" />
		        <asp:Button runat="server" Text="MACH" BackColor="#999999" Height="100px" Width="150px" ForeColor="White" ID="btn2" />
		        <asp:Button runat="server" Text="MACH" BackColor="#999999" Height="100px" Width="150px" ForeColor="White" ID="btn3" />--%>
		        <asp:SqlDataSource ID="conexion1" runat="server" ConnectionString="<%$ ConnectionStrings:TRKConnectionString %>" 
			        SelectCommand="
				        SELECT Producto_T.nombreProductoT, Producto_T.imgProductoT, 
				        Producto_B.nombreProductoB, Producto_B.imgProductoB
				        FROM Producto_B, Producto_T   
				        WHERE Producto_T.idProductoT = Producto_B.idProductoB 
				        AND Producto_T.idEtiqueta = Producto_B.idEtiquetaB 
				        AND Producto_T.idUsuario = 1">
		        </asp:SqlDataSource>	
            </div>
        </div>
    </div>
</asp:Content>
