<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="AplicacionWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container">
    <div class="row">
        <%foreach (Dominio.Articulo item in listas)
            {%>
            <div class="col mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title"> <%=item.Nombre%> </h5>
                        <p class="card-text"><%=item.Marca %></p>
                    </div>
                    <img src="<%=item.ImagenUrl %>" class="card-img-top" alt="..."> <!-- los ... aparecen cuando no hya imagen -->
                    <div class="card-body">
                        <p class="card-text"><%="$ " + item.Precio.ToString("0.00") %></p>
                        <a href="Carrito.aspx?id=<% =item.Id %>" class="btn btn-primary">Agregar Carrito</a>
                        <a href="Carrito.aspx?id=<% = item.Id %>"><i class="fas fa-heart"></i></a>
                    </div>
                </div>
            </div>
                <%} %>
        </div>
    </div>

</asp:Content>
