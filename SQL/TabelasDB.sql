Create database Teste;

Use Teste;


--Criando sequences

CREATE SEQUENCE SEQ_Endereco
    as int
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE;
GO

CREATE SEQUENCE SEQ_Cliente
    as int
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE;
GO


CREATE SEQUENCE SEQ_Usuario
	as int
    START WITH 1
    INCREMENT BY 1
    MINVALUE 0
    NO MAXVALUE
    NO CACHE;
GO


--Criando Tabelas

create table Endereco
(
	id_endereco int default next value for SEQ_Endereco,
	rua Nvarchar(45),
	CEP NVarchar(45),
	estado NVarchar(20),
	cidade NVarchar(45),
	complemento NVarchar(45),

	constraint pk_endereco primary Key(id_endereco)
);

GO

create table Cliente
(
	id_cliente int default next value for SEQ_Cliente,
	id_endereco int,
	nome Nvarchar(45),
	email NVarchar(45),
	telefone NVarchar(20),

	Constraint pk_cliente primary Key(id_cliente),
	Constraint fk_cliente_endereco FOREIGN KEY (id_endereco) REFERENCES Endereco(id_endereco)

);

GO

create table Usuarios
(
	id int  default next value for SEQ_Usuario,
	nome Nvarchar(45),
	senha Nvarchar(100),
	email Nvarchar(45),
	ativado bit,

	constraint pk_User primary Key(id)
);

GO

-- Criando Views

create view Clientes
as
	select Cliente.id_cliente, 
	Cliente.nome, 
	Cliente.Email, 
	Cliente.Telefone, 
	Endereco.Rua, 
	Endereco.CEP, 
	Endereco.cidade, 
	Endereco.estado, 
	Endereco.complemento,
	Endereco.id_endereco
	from Cliente inner join Endereco
		on Cliente.id_endereco = Endereco.id_endereco;

GO