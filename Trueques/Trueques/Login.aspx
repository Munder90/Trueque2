<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Trueques.WebForm1" %>

<asp:Content ID="Login" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel text-center">
            <br />
            <%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True"  Text="Inicio de sesion"></asp:Label>--%>
            <br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"  Text="Email"></asp:Label>
            &nbsp;&nbsp; 
            <asp:TextBox ID="usuario" runat="server"></asp:TextBox>
            <br /><br />
            &nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"  Text="Password&nbsp;&nbsp;"></asp:Label>
            &nbsp; <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="error" runat="server" ></asp:Label>
            <br /><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar sesion" BackColor="#999999" ForeColor="Black" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="registrarse" runat="server" OnClick="registrarse_Click" Text="Registrarse" BackColor="#999999" ForeColor="Black" />
            <br /><br />
            <%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
            <asp:Button ID="Recuperar" runat="server" OnClick="Recuperar_Click" Text="Recuperar Contraseña" BackColor="#999999" ForeColor="Black" />
        </div>
    </div>
</asp:Content>
