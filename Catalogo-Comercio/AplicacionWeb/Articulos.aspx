<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="AplicacionWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container">
    <div class="row">
        <%foreach (Dominio.Articulo item in lista)
            {%>
            <div class="col mb-4">
                <div class="card">
                    <img src="<%=item.ImagenUrl %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text"><%=item.Descripcion %></p>
                    </div>
                </div>
            </div>
                <%} %>
        </div>
    </div>

</asp:Content>
