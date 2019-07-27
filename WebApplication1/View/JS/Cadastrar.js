function PegaDados() {
    $.ajax({
        type: "POST",
        url: "Cadastrar.aspx/BuscaNome",

        data: "{nome: '" + $("#txtnome").val() + "', email: '" + $("#txtemail").val() + "', senha: '" + $("#txtsenha").val() + "', confsenha: '" + $("#txtconfsenha").val() + "'}", //5
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (resposta) {
            $("#txtnome").val(resposta.d);
            alert("Dados enviados");
        }
    })

}

