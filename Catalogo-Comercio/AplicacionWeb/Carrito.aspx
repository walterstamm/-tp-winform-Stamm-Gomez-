<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mis Articulos </h1>

    <div class="container">

        <table class="table table-striped">
            <tr>
                <th>
                    <h5>PRODUCTO</h5>
                </th>
                <th>
                    <h5>PRECIO</h5>
                </th>
                <th>

                </th>
            </tr>

            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>

                    <tr>
                        <td>
                            <%#Eval("Nombre")%>              
                        </td>
                        <td>
                            <%#Eval("Precio")%>
                        </td>
                        <%# Eval("cantidadArticulos")%>
                        <td>
                            <asp:Button Text="Elimnar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

    </div>
    <br />
    <br />

    <asp:Button Text="Ver mas Productos" ID="btnAgregarArticulos" OnClick="btnAgregarArticulos_Click" runat="server" />
    <!--OnClick="btnAgregarArticulos_Click" -->


</asp:Content>
