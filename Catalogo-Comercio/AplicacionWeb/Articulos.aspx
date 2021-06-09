<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="AplicacionWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <div class="container">
        <div class="row">
            <%foreach (Dominio.Articulo item in listas)
                {%>
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="<%=item.ImagenUrl %>" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title"><%=item.Nombre%></h5>
                    <p class="card-text"><%="$ " + item.Precio.ToString("0.00") %></p>
                    <a href="Carrito.aspx?Id=<% = item.Id %> " class="btn btn-primary">Agregar al Carrito</a>
                </div>
            </div>
            <%} %>
        </div>
    </div>
</asp:Content>
