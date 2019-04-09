<%@ Page Title="Restablecer Contraseña" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cambia_Password.aspx.cs" Inherits="Trueques.Cambia_Password" %>

<asp:Content ID="Cambia_Password" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="card-panel">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <%--<asp:Label ID="Label4" runat="server" Font-Bold="True"  Text="Restablecer Contraseña"></asp:Label>--%>
            <br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"  Text="Nuevo Password"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="con_pass_1" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="nopass" runat="server" ></asp:Label>
            <br /><br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server"  Text="Confirma Password"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="con_pass_2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="nopass2" runat="server" ></asp:Label>
            <br /><br /><br />
            <asp:Button ID="Restablecer" runat="server" BackColor="#999999" ForeColor="Black" Text="Restablecer" OnClick="Restablecer_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#999999" ForeColor="Black" OnClick="Button1_Click" Text="Cancelar" />
        </div>
    </div>
</asp:Content>
