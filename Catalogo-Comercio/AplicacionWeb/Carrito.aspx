<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Articulos en Carrito de Compras </h1>



    <table>
        <tr>
            <td>
                <h5>PRODUCTO</h5>
            </td>
            <td>
                <h5>PRECIO</h5>
            </td>
        </tr>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>

                <tr>
                    <td>
                        <%#Eval("Nombre")%>              
                    </td>
                    <td>
                        <asp:Button Text="Elimnar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("Id")%>' runat="server" />
                    </td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>


    <br />
    <br />

    <asp:Button Text="Página Producto" ID="btnAgregarArticulos" OnClick="btnAgregarArticulos_Click" runat="server" />
    <!--OnClick="btnAgregarArticulos_Click" -->


</asp:Content>
