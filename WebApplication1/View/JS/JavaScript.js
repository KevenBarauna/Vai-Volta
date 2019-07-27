var corpo_tabela = document.querySelector("tbody");

function chamaelemento() {
    var novo_elemento = document.createElement("p")
    var texto_de_p = document.createTextNode("Olá mundo")
    novo_elemento.appendChild(texto_de_p)
    document.body.appendChild(novo_elemento)
}

function Entrevista(nome, ano) {

    this.nome = nome;
    this.ano_informado = ano;

    this.mostra_dados = function () {
        console.log("O nome é " + this.nome + " O ano é: " + this.ano_informado)
    }

    this.criar_linha_tabela = function () {
        //Criar elementos
        var linha = document.createElement("tr");

        var campo_nome = document.createElement("td");
        var campo_ano = document.createElement("td");

        //Criar nós
        campo_nome.className = "table"

        //Criar nós
        var texto_nome = document.createTextNode(this.nome);
        var texto_ano = document.createTextNode(this.ano_informado);

        //Vincular os nós aos elementos
        campo_nome.appendChild(texto_nome);
        campo_ano.appendChild(texto_ano);

        linha.appendChild(campo_ano);
        linha.appendChild(campo_idade);

        //Vincular os elementos ao docmento
        corpo_tabela.appendChild(linha);

    }

}