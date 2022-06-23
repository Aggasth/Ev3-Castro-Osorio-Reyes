<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="EvaluacionASP_Castro_Osorio_Reyes.Ingresar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container" style="background-color:beige; border-radius:10px; display:flex; justify-content: center; text-align: center;">
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="row" style="display: flex; justify-content:center;text-align:center;">
                        <div class="mb-3">
                        <label for="TituloAgregar" class="form-label">Agregar Medidores</label>
                    </div>
                    <div class="mb-3">
                        <label for="IDMedidor" class="form-label">
                            Ingresar ID: 
                        </label>
                        <asp:TextBox ID="txtId" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="ConsumoMedidor">Ingresar Consumo: </label>
                        <asp:TextBox ID="txtConsumo" runat="server" type="number" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-check">
                        <label for="TipoMedidor" class="form-label">Seleccione el tipo: </label>
                        <asp:RadioButtonList runat="server" ID="tiposRbl">
                                <asp:ListItem Selected="True" Value="1" Text="Agua"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Luz"></asp:ListItem>
                                <asp:ListItem Value="3" Text="Gas"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="mb-3">
                        <label for="FechaMedidor" class="form-label">Fecha: </label>
                        <asp:TextBox ID="fechaBox" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar Medidor" OnClick="btnIngresar_Click" />
                    </div>
                    <div class="mb-3">
                        <asp:Label runat="server" ID="successMsg" CssClass="text-success"></asp:Label>
                        <asp:Label runat="server" ID="errorMsg" CssClass="text-danger"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
