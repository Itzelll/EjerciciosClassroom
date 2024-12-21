<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Forms.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar contrato</h2>
    <div class="form-horizontal">
        <dl class="row">
            <dt class="col-sm-2 text-end">ID</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbid" runat="server"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Cliente</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbcliente" runat="server"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Tipo Contrato</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbtipo" runat="server"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Fecha Inicio</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbinicio" runat="server" TextMode="Date"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Fecha Final</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbfinal" runat="server" TextMode="Date"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Monto</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbmonto" runat="server"></asp:TextBox>
            </dd>
            <dt class="col-sm-2 text-end">Descripcion</dt>
            <dd class="col-sm-10">
                <asp:TextBox ID="tbdesc" runat="server"></asp:TextBox>
            </dd>
        </dl>
    </div>
    <asp:Button ID="btnEdit" runat="server" Text="Guardar" OnClick="btnEdit_Click" CssClass="btn btn-success"/>
    <asp:Button ID="btnInicio" runat="server" Text="Regresar" OnClick="btnInicio_Click" CssClass="btn btn-secondary" />

</asp:Content>
