<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Forms.Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear contrato</h2>
    <div class="form-horizontal">
        <dl class="row">
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
    <asp:Button ID="btnCreate" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnCreate_Click" />
    <asp:Button ID="btnInicio" runat="server" Text="Regresar" CssClass="btn btn-secondary" OnClick="btnInicio_Click" />


</asp:Content>
