<%@ Page Title="Principios SOLID" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SOLID.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Principios SOLID</h1>
        <p class="lead">Los principios SOLID son la base para la confección de aplicaciones extensibles, mantenibles y reusables</p>
     
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Adquisición</h2>
            <p>
                Aqui podria ir la generacion de la señal inicial
            </p>
            <p>
                <a class="btn btn-default" href="">Adquirir &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Procesamiento</h2>
            <p>
               Aqui podra ir el procesamiento de la señal
            </p>
            <p>
                <a class="btn btn-default" href="">Procesar &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Repositorio</h2>
            <p>
                Aqui podra ir el guardado de la señal
            </p>
            <p>
                <a class="btn btn-default" href="">Guardar &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
