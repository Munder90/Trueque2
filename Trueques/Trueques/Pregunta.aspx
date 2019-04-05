<%@ Page Title="Recuperar Contraseña" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pregunta.aspx.cs" Inherits="Trueques.Pregunta" %>

<asp:Content ID="Pregunta" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True"  Text="Recuperar Contraseña"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"  Text="Ingresa el Email Registrado:&nbsp;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="email_recuperar" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="¿Cual es el nombre de tu primer mascota?" ></asp:Label>
            <br />
            <asp:TextBox ID="mascota_recuperar" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="recumensaje" runat="server" ></asp:Label>
            <br />
            <br />
            <asp:Button ID="recuperar" runat="server" OnClick="recuperar_Click" Text="Enviar" BackColor="#999999" ForeColor="Black" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="login_rec" runat="server" OnClick="login_rec_Click" Text="Login" BackColor="#999999" ForeColor="Black" />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
