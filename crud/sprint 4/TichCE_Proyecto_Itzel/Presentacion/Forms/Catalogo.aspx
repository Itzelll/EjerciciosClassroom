<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="Presentacion.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Catalogo de Contratos</h2>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" />
    <hr />

    <asp:GridView ID="gvContratos" runat="server" AutoGenerateColumns="False" AllowPaging="True" CssClass="table" GridLines="Horizontal" OnPageIndexChanging="gvContratos_PageIndexChanging" OnRowCommand="gvContratos_RowCommand" PageSize="3">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField HeaderText="Cliente" DataField="cliente" />
        <asp:BoundField HeaderText="Tipo de Contrato" DataField="tipoContrato" />
        <asp:BoundField HeaderText="Monto" DataField="monto" />
        <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
        <asp:ButtonField Text="Detalles" CommandName="btnDetalles" >
        <ControlStyle CssClass="btn btn-secondary" />
        </asp:ButtonField>
        <asp:ButtonField Text="Editar" CommandName="btnEditar" >
        <ControlStyle CssClass="btn btn-warning" />
        </asp:ButtonField>
        <asp:ButtonField Text="Eliminar" CommandName="btnEliminar" >
        <ControlStyle CssClass="btn btn-danger" />
        </asp:ButtonField>
    </Columns>
</asp:GridView>

</asp:Content>
