<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Vai&Volta</title>

    <link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Sniglet&display=swap" rel="stylesheet"/>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="JS/Sobre.js"></script>

    <link href="CSS/Sobre.css" rel="stylesheet"/>

</head>




<body>
            <div id="corpo">
    	<div id="background">
               <div id="menu"> 
                <a id='LINKCF' href="Sobre.aspx">Como funciona</a>
                <a id='LINKCD' href="Cadastrar.aspx">Cadastrar</a>
               </div>
            <link href="Sobre.css" rel="stylesheet" />
               <h1>Como funciona ?</h1>
               <h2 id="subtitulo">Uma forma para você não esquecer para quem emprestou cada coisa.</h2>
               <h2 id="titulo">Crie sua conta</h2>
               <h3 id="item">Crie sua conta de uma forma simples, seu Email, nome e senha, sem complicações.</h3>
               <h2 id="titulo">Vai emprestar?</h2>
               <h3 id="item">Cadastre o que vai ser emprestado, para quem vai ser <br/> emprestado(nome e telefone) e qual a data de devolução.</h3>
               <h2 id="titulo">O dia de devolução</h2>
               <h3 id="item">Quando o dia do seu amigo te devolver o produto chegar<br/> vamos mandar uma mensagem pra ele, lembrando que <br/> tudo o que vai volta.</h3>
               <button type="button" onclick="comecar()" id="btnvamoscomecar">Vamos começar!</button>
               <div id="linhaazul"></div>
        </div>   
    </div>
</body>
</html>
