<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Forms.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalles del contrato</h2>
    <div class="form-horizontal">
        <dl class="row">
            <dt class="col-sm-2 text-end">ID</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Cliente</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lblcliente" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Tipo Contrato</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lbltipo" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Fecha Inicio</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lblinicio" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Fecha Final</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lblfinal" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Monto</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lblmonto" runat="server" Text=""></asp:Label>
            </dd>
            <dt class="col-sm-2 text-end">Descripcion</dt>
            <dd class="col-sm-10">
                <asp:Label ID="lbldesc" runat="server" Text=""></asp:Label>
            </dd>
        </dl>
    </div>
    <asp:Button ID="btnInicio" runat="server" Text="Regresar" OnClick="btnInicio_Click" CssClass="btn btn-secondary" />

</asp:Content>
