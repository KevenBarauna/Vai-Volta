<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Vai&Volta</title>

    <script src="https://apis.google.com/js/platform.js" async defer></script>
    <meta name="google-signin-client_id" content="198104873046-1co5fanbmg6uss6qlah5ppi2o8ejltmh.apps.googleusercontent.com">

    <link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Sniglet&display=swap" rel="stylesheet"/>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="JS/Login.js"></script>

    <link href="CSS/Login.css" rel="stylesheet"/>

</head>

<body>

       <div id="corpo">
    	<div id="background">
               <div id="menu"> 
                <a id='LINKCF' href="Sobre.aspx">Como funciona</a>
                <a id='LINKCD' href="Cadastrar.aspx">Cadastrar</a>
               </div>
               <h1>Vai&Volta</h1> 

               <h3>Nome:</h3> 
               <input type="text" name="" id="txtnome"/>

               <h3>Senha:</h3>
               <input type="text" name="" id="txtsenha"/>

             <div class="g-signin2" data-onsuccess="onSignIn"></div>

              <button type="button" onclick="PeganomeAPI()" id="btnvamoscomecar">Entrar</button>
        </div>   
    </div>

</body>
</html>
