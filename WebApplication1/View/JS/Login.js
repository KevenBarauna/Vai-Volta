function onSignIn(googleUser) {

    var profile = googleUser.getBasicProfile();
    console.log('ID: ' + profile.getId()); // Do not send to your backend! Use an ID token instead.
    // var nome = console.log('Name: ' + profile.getName());
    var Usernome = profile.getName();
    console.log('Image URL: ' + profile.getImageUrl());
    console.log('Email: ' + profile.getEmail()); // This is null if the 'email' scope is not present.

    alert('Você fez Login como: ' + Usernome)

    location.href = "Home.aspx"

}

function verificausuario() {

        $.ajax({
            type: "POST",
            url: "Login.aspx/VerificaUsuario",

            data: "{nome: '" + $("#txtnome").val() + "',  senha: '" + $("#txtsenha").val() + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",

            success: function (resposta) {
                $("#txtnome").val(resposta.d);
                alert("Dados enviados");
            }
        })

}