<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> "Articulos en Carrito de Compras" </h1>


        
    <table>
        <tr>
            <td style="white-space: 90px"> <h5>PRODUCTO</h5>    
            </td>
            <td style="white-space: 90px"> <h5>PRECIO</h5> 
            </td>  
            <td style="white-space: 110px">  <h5>STOCK</h5>
            </td>  
            <td style="white-space: 70px"> <h5>IMAGEN</h5>
            </td>  
        </tr>

        <% foreach (Dominio.Articulo item in Carrito)
            {%>

        <tr>
            <td style="white-space: 90px">
                <asp:Label Text="text" ID="lblSeleccionado" runat="server" />
            </td>
            <td style="white-space: 90px">
                <asp:Label Text="text" ID="lblPrecio" runat="server" />
            </td>
            <td style="white-space: 110px">    
                <asp:Label Text="text" ID="lblStock" runat="server" />
            </td>
            <td style="color:blue">    
                <asp:Label  Text="text" ID="lblUrlImagen" runat="server" />
            </td>
        </tr>
        <%} %>
    </table>
    

    <br />
    <br />

    <asp:Button Text="Página Producto" ID="btnAgregarArticulos" OnClick="btnAgregarArticulos_Click" runat ="server" /> <!--OnClick="btnAgregarArticulos_Click" -->

  
</asp:Content>
