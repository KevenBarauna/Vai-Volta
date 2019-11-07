--=====================================================
--USAR O BANCO DE DADOS CRIADO
--=====================================================
use [C:\USERS\KEVEN.BARAUNA\DOCUMENTS\_PROJETOS\_PESSOAL\21 - VAIEVOLTA\VAIEVOLTA\VAIEVOLTA\APP_DATA\DATAVASEVAIEVOLTA.MDF]

--=====================================================
--CRIAR TABELA USUARIO
--=====================================================

CREATE TABLE TB_Usuario(
id int,
nome varchar(30),
senha varchar (30),
primary key (id)
);

--=====================================================
--VER A TABELA USUARIO
--=====================================================

SELECT * FROM TB_Usuario;

--=====================================================
--CRIAR TABELA EMPRESTIMO
--=====================================================

CREATE TABLE TB_Emprestimo(
id int,
obejto varchar(30),
pessoa varchar(30),
telefone varchar(30),
datadevolucao varchar(30),
dataemprestimo varchar(30),
primary key (id)
);

--=====================================================
--VER A TABELA EMPRESTIMO
--=====================================================

SELECT * FROM TB_Emprestimo;

--=====================================================
--ADICIONANDO A FOREIGN KEY DE EMPRESTIMO EM USUAIO
--=====================================================

ALTER TABLE TB_Usuario add IDEmprestimo INT;

ALTER TABLE TB_Usuario
ADD FOREIGN KEY (IDEmprestimo) REFERENCES TB_Emprestimo(id);

--=====================================================
--VER A TABELA USUARIO
--=====================================================

SELECT * FROM TB_Usuario;


--=====================================================
--APAGAR ALGUMA TABELA
--=====================================================

--drop TABLE TB;

--=====================================================
--PREENCHER TABELA DE USUARIO COM ADMIN
--=====================================================

INSERT INTO TB_Usuario (id,nome,senha) VALUES ('1', 'Admin','Admin');

--=====================================================
--PREENCHER TABELA DE USUARIO COM KEVEN
--=====================================================

INSERT INTO TB_Usuario (id,nome,senha) VALUES ('50', 'Keven','123');


--=====================================================
--VER A TABELA USUARIO
--=====================================================

SELECT * FROM TB_Usuario;
