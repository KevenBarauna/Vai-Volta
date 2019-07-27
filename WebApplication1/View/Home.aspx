<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Vai&Volta</title>


    <script type="text/javascript" src="JS/Home.js"></script>
    <link href="CSS/Home.css" rel="stylesheet"/>

</head>




<body>

    
<h2>Olá #'Usuario'</h2>

<table>
  <tr>
    <th>Amigo</th>
    <th>Item</th>
    <th>Data</th>
    <th>Telefone</th>
    <th>Editar</th>
    <th>Apagar</th>
  </tr>
  <tr>
    <td>Alex</td>
    <td>Controle Xbox</td>
    <td>20.05.2019</td>
    <td>(71)9 9310-6733</td>
      <td><a href="Sobre.aspx">Editar</a></td>
      <td><a href="Sobre.aspx">Apagar</a></td>
  </tr>
  <tr>
    <td>Keven</td>
    <td>Filme Vingadores</td>
    <td>31.05.2019</td>
    <td>(71)9 9310-6733</td>
      <td><a href="Sobre.aspx">Editar</a></td>
      <td><a href="Sobre.aspx">Apagar</a></td>
  </tr>
  <tr>
    <td>Patricia</td>
    <td>Jogo CS:GO</td>
    <td>01.06.2019</td>
    <td>(71)9 9310-6733</td>
      <td><a href="Sobre.aspx">Editar</a></td>
      <td><a href="Sobre.aspx">Apagar</a></td>
  </tr>
  <tr>
    <td>Ludmila</td>
    <td>Pen-drive</td>
    <td>20.09.2019</td>
    <td>(71)9 9310-6733</td>
      <td><a href="Sobre.aspx">Editar</a></td>
      <td><a href="Sobre.aspx">Apagar</a></td>
  </tr>
  <tr>
    <td>Rebeca</td>
    <td>R$10,00</td>
    <td>Canada</td>
    <td>(71)9 9310-6733</td>
      <td><a href="Sobre.aspx">Editar</a></td>
      <td><a href="Sobre.aspx">Apagar</a></td>
  </tr>

</table>

    <button type="button" onclick="Adicionar()" id="btnadicionar">Adicionar</button>

</body>
</html>
