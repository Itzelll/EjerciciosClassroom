<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Tich_WebFormADO_Estadios.Forms.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Eliminar Grupo Comercial</h2>
    <h3>¿Estas seguro de eliminar el grupo comercial?</h3>
    <dl>
        <dt>Id:</dt>
        <dd>
            <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
        </dd>
        <dt>Nombre
        </dt>
        <dd>
            <asp:Label ID="lblnombre" runat="server" Text=""></asp:Label>
        </dd>
        <dt>Direccion
        </dt>
        <dd>
            <asp:Label ID="lbldir" runat="server" Text=""></asp:Label>
        </dd>
        <dt>RFC
</dt>
        <dd>
            <asp:Label ID="lblrfc" runat="server" Text=""></asp:Label>
        </dd>
        <dt>Telefono
</dt>
        <dd>
            <asp:Label ID="lbltel" runat="server" Text=""></asp:Label>
        </dd>
        <dt>Email
</dt>
        <dd>
            <asp:Label ID="lblcorreo" runat="server" Text=""></asp:Label>
        </dd>
    </dl>
    <hr />
    <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" CssClass="btn btn-danger"/>
    <asp:Button ID="btnIndex" runat="server" Text="Regresar" OnClick="btnIndex_Click" CssClass="btn btn-secondary"/>
</asp:Content>
