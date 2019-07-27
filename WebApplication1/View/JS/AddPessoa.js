
function CadastraItem() {
    $.ajax({
        type: "POST",
        url: "AddPessoa.aspx/CadastraItem",

        data: "{Pessoa: '" + $("#txtpessoa").val() + "', Telefone: '" + $("#txttelefone").val() + "', Item: '" + $("#txtitem").val() + "', Data: '" + $("#txtdata").val() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (resposta) {
            alert("Dados enviados");
        }
    })

    location.href = "Home.aspx"

}
