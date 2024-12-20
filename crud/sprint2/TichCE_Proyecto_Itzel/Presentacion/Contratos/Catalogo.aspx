<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="Presentacion.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Catalogo de Contratos</h2>
    <asp:Button ID="btnAgregar" runat="server" Text="Agrgar nuevo" OnClick="btnAgregar_Click" />

    <asp:GridView ID="gvContratos" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField HeaderText="Cliente" DataField="cliente" />
            <asp:BoundField HeaderText="Tipo de Contrato" DataField="tipoContrato" />
            <asp:BoundField HeaderText="Fecha Inicio" DataField="fechaInicio" />
            <asp:BoundField HeaderText="Fecha Fin" DataField="fechaFin" />
            <asp:BoundField HeaderText="Monto" DataField="monto" />
            <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
            <asp:ButtonField Text="Detalles" />
            <asp:ButtonField Text="Editar" />
            <asp:ButtonField Text="Eliminar" />
        </Columns>
    </asp:GridView>

</asp:Content>
