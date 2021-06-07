<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> "Articulos en Carrito de Compras" </h1>


        
    <table>
        <tr>
            <td> <h5>PRODUCTO</h5>    
            </td>
            <td> <h5>PRECIO</h5> 
            </td>  
            <td>  <h5>STOCK</h5>
            </td>  
            <td> <h5>IMAGEN</h5>
            </td>  
        </tr>

        <% foreach (Dominio.Articulo item in carrito)
            {%>

        <tr>
            <td>
                <% = item.Nombre %>                
            </td>
            <td>
                <% = item.Precio %>
            </td>
            <td>    
                <% = "Disponible" %>                
            </td>
            <td style="color:blue">
                <% = item.ImagenUrl %>                
            </td>
        </tr>
        <%} %>
    </table>
    

    <br />
    <br />

    <asp:Button Text="Página Producto" ID="btnAgregarArticulos" OnClick="btnAgregarArticulos_Click" runat ="server" /> <!--OnClick="btnAgregarArticulos_Click" -->

  
</asp:Content>
