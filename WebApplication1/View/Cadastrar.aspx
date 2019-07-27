<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Vai&Volta</title>

    <link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Sniglet&display=swap" rel="stylesheet"/>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="JS/Cadastrar.js"></script>

    <link href="CSS/Cadastrar.css" rel="stylesheet"/>

</head>

<body>

 <div id="corpo">
        <div id="background">
            <div id="menu">
                <a id='LINKCF' href="Sobre.aspx">Como funciona</a>
                <a id='LINKCD' href="Cadastrar.aspx">Cadastrar</a>
            </div>
            <h1>Cadastrar</h1>

            <h3>Nome:</h3>
            <input type="text" name="" id="txtnome"/>

            <h3>E-mail:</h3>
            <input type="text" name="" id="txtemail"/>

            <h3>Senha:</h3>
            <input type="text" name="" id="txtsenha"/>

            <h3>Confirme<br/>sua senha:</h3>
            <input type="text" name="" id="txtconfsenha"/>

            <button type="button" onclick="PegaDados()" id="btnvamoscomecar">Confirmar</button>
            <div id="linhaazul"></div>
        </div>
    </div>


</body>
</html>
