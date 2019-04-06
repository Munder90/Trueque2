<%@ Page Title="Modificar datos de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificacion.aspx.cs" Inherits="Trueques.Modificacion" %>

<asp:Content ID="Modificacion" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Font-Bold="True"  Text="Modificar Datos De Usuario"></asp:Label>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"  Text="Nombre:&nbsp;"></asp:Label>
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_nombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            &nbsp;
            <asp:Label ID="Label2" runat="server"  Text="Apodo:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_apodo" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label9" runat="server"  Text="Ciudad:&nbsp;&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_ciudad" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;<asp:Label ID="Label8" runat="server"  Text="Telefono:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_telefono" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server"  Text="Email:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_email" runat="server" Enabled="False" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server"  Text="Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mod_password" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:Label ID="mod_nopass" runat="server" ></asp:Label>
            <br /><br />
            &nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server"  Text="Confirmar Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="mod_confpassword" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:Label ID="mod_nopass2" runat="server" ></asp:Label>
            <br /><br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server"  Text="Fecha de nacimiento:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="modfecha" runat="server" Enabled="False"></asp:TextBox>
            <br /><br />
            &nbsp;
            <asp:Label ID="Label3" runat="server"  Text="Imagen de Perfil&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Image ID="mod_perfil" runat="server" Height="70px" Width="111px" />
            &nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="Black" />
            <br /><br />
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ver Datos" BackColor="#999999" ForeColor="Black" Visible="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Actualizar" runat="server" OnClick="Actualizar_Click" Text="Actualizar" BackColor="#999999" ForeColor="Black" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancelar" runat="server" OnClick="Cancelar_Click" Text="Cancelar" BackColor="#999999" ForeColor="Black" />
            <asp:Label ID="test" runat="server" Visible="False" ></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
