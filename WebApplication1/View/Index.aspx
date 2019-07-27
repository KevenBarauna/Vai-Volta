<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Vai&Volta</title>

    <link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Sniglet&display=swap" rel="stylesheet"/>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="JS/Index.js"></script>

    <link href="CSS/Index.css" rel="stylesheet"/>

</head>

<body>

       <div id="corpo">
        <div id="background">
            <div id="menu">
                <a id='LINKCF' href="Sobre.aspx">Como funciona</a>
                <a id='LINKCD' href="Cadastrar.aspx">Cadastrar</a>
            </div>
            <h1>Vai&Volta</h1>
            <h2>
                Tenha controle do que
                é seu, não perca o amigo nem<br/>
                seu objeto, use o vai&volta.
            </h2>
            <div id="linhaazul"></div>
            <button type="button" onclick="comecar()" id="btnvamoscomecar">Vamos começar!</button>
            <button type="button" onclick="alert('Vídeo em manutenção')" id="btnplay">►</button>
        </div>
    </div>

</body>
</html>
