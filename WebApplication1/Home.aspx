<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vai&Volta</title>

    <link href="https://fonts.googleapis.com/css?family=Quicksand&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Sniglet&display=swap" rel="stylesheet">

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
</head>


        <style type="text/css">

        body {
            background-color: black;
        }

        #background {
            background-image: url("img-background.jpg");
            /* width: 1920px;
            height: 1080px;*/
            width: 1900px;
            height: 910px;
        }

        #menu {
            padding: 10px;
            color: #ffffff;
            font-family: 'Sniglet', cursive;
            /* background-color: blue; */
        }

        #LINKCF {
            font-family: 'Sniglet', cursive;
            font-size: 15pt;
            padding: 1px;
            color: #ffffff;
            margin-left: 1600px;
            margin-top: -2000px;
            text-decoration: none;
            /*background-color: red; */
        }

        #LINKCD {
            font-family: 'Sniglet', cursive;
            font-size: 15pt;
            padding: 1px;
            color: #ffffff;
            margin-left: 20px;
            text-decoration: none;
            /* background-color: red;*/
        }

        h3 {
            font-size: 50pt;
            color: #ffffff;
            width: 170px;
            color: #ffffff;
            font-size: 10pt;
            font-family: 'Quicksand', sans-serif;
            margin-top: 0px;
            margin-left: 780px;
            /*background-color:blue;*/
        }


        h1 {
            width: 500px;
            color: #ffffff;
            font-size: 80pt;
            font-family: 'Quicksand', sans-serif;
            margin-top: 5%;
            margin-left: 700px;
            /*  background-color: blue; */
        }

        button {
            background-color: #ff2764;
            font-size: 12pt;
            color: #ffffff;
            font-family: 'Quicksand', sans-serif;
            height: 0.9cm;
            width: 4cm;
            border-radius: 50px;
            border-style: none;
            margin-left: 850px;
            margin-top: 30px;
            cursor: pointer;
        }

        #txtnome {
            border-radius: 50px;
            border-style: none;
            height: 20px;
            margin-left: 850px;
            margin-top: -30px;
            position: absolute;
        }

        #txtemail {
            border-radius: 50px;
            border-style: none;
            height: 20px;
            margin-left: 850px;
            margin-top: -30px;
            position: absolute;
        }

        #txtsenha {
            border-radius: 50px;
            border-style: none;
            height: 20px;
            margin-left: 850px;
            margin-top: -30px;
            position: absolute;
        }

        #txtconfsenha {
            border-radius: 50px;
            border-style: none;
            height: 20px;
            margin-left: 850px;
            margin-top: -40px;
            position: absolute;
        }
    </style>

<body>

        <div id="corpo">
        <div id=background>
            <div id="menu">
                <a id='LINKCF' href="https://www.google.com/">Como funciona</a>
                <a id='LINKCD' href="https://www.google.com/">Cadastrar</a>
            </div>
            <h1>Cadastrar</h1>

            <h3>Nome:</h3>
            <input type="text" name="" id="txtnome">

            <h3>E-mail:</h3>
            <input type="text" name="" id="txtemail">

            <h3>Senha:</h3>
            <input type="text" name="" id="txtsenha">

            <h3>Confirme</br>sua senha:</h3>
            <input type="text" name="" id="txtconfsenha">

            <input id ="txtDescricao" readonly="true" />

            <button type="button" onclick="PegaDados()" id="btnvamoscomecar">Confirmar</button>
            <div id="linhaazul"></div>
        </div>
    </div>

    <script>
        function PegaDados()
        {
            $.ajax({
                type: "POST",
                url: "Cadastrar.aspx/BuscaNome",

               // data: "{nome: '" + $("#txtnome").val() + "'}", //1
                //data: "{nome: 'oi', email: 'Oi2'}", //2
               // data: "{nome: '" + $("#txtnome").val() + "', email: 'Oi2'}", //3
                //data: "{nome: '" + $("#txtnome").val() + "', email: '" + $("#txtemail").val() + "'}", //4
                data: "{nome: '" + $("#txtnome").val() + "', email: '" + $("#txtemail").val() + "', senha: '" + $("#txtsenha").val() + "'}", //5
                contentType: "application/json; charset=utf-8",
                dataType: "json",

                success: function (resposta) {
                    $("#txtnome").val(resposta.d);
                    alert("Dados enviados");
                }
            })

        }
    </script>
</body>
</html>
