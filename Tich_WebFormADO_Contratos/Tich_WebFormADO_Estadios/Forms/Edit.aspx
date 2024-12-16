<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Tich_WebFormADO_Estadios.Forms.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Grupo Comercial</h2>
    <dl>
        <dt>Id:</dt>
        <dd>
            <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
        </dd>
        <dt>Nombre
        </dt>
        <dd>
            <asp:TextBox ID="tbnombre" runat="server"></asp:TextBox>
        </dd>
        <dt>Direccion
        </dt>
        <dd>
            <asp:TextBox ID="tbdir" runat="server"></asp:TextBox>
        </dd>
        <dt>RFC
</dt>
        <dd>
            <asp:TextBox ID="tbrfc" runat="server"></asp:TextBox>
        </dd>
        <dt>Telefono
</dt>
        <dd>
            <asp:TextBox ID="tbtel" runat="server"></asp:TextBox>
        </dd>
        <dt>Email
</dt>
        <dd>
            <asp:TextBox ID="tbcorreo" runat="server"></asp:TextBox>
        </dd>
    </dl>
    <hr />
    <asp:Button ID="btnEdit" runat="server" Text="Guardar" OnClick="btnEdit_Click" CssClass="btn btn-success"/>
    <asp:Button ID="btnIndex" runat="server" Text="Regresar" OnClick="btnIndex_Click" CssClass="btn btn-secondary"/>
</asp:Content>
