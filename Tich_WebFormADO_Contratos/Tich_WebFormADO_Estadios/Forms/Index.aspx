<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Tich_WebFormADO_Estadios.Forms.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Listado grupos comerciales</h1>
        <hr />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary"/>
        <hr />
    <asp:GridView ID="gvGrupos" runat="server" AutoGenerateColumns="False" AllowPaging="True" BorderStyle="None" CssClass="table" GridLines="Horizontal" OnPageIndexChanging="gvGrupos_PageIndexChanging" OnRowCommand="gvGrupos_RowCommand" PageSize="3" >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="direccion" HeaderText="Direccion" />
            <asp:BoundField DataField="rfc" HeaderText="RFC" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="email" HeaderText="Correo" />
            <asp:ButtonField CommandName="btnDetalles" Text="Detalles">
                <ControlStyle CssClass="btn btn-warning" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnEditar" Text="Editar">
                <ControlStyle CssClass="btn btn-success" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnEliminar" Text="Eliminar">
            <controlstyle cssclass="btn btn-danger" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
