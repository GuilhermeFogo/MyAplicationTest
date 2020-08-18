Create database teste;

create table Endereco(
	id_endereco int IDENTITY(1,1),
	rua Nvarchar(45),
	CEP NVarchar(45),
	estado NVarchar(20),
	cidade NVarchar(45),
	complemento NVarchar(45),

	constraint pk_endereco primary Key(id_endereco)
);


create table Cliente(
	id_cliente int IDENTITY(1,1),
	id_endereco int,
	nome Nvarchar(45),
	email NVarchar(45),
	telefone NVarchar(20),
	
	Constraint pk_cliente primary Key(id_cliente),
	Constraint fk_cliente_endereco FOREIGN KEY (id_endereco) REFERENCES Endereco(id_endereco)

);

select Cliente.Nome, Cliente.Email, Cliente.Telefone, Endereco.Rua, Endereco.CEP, Endereco.cidade,Endereco.estado 
from Cliente inner join Endereco 
on Cliente.id_cliente = Endereco.id_endereco;



create view Clientes as
select  Cliente.id_cliente, Cliente.nome, Cliente.Email, Cliente.Telefone, Endereco.Rua, Endereco.CEP, Endereco.cidade,Endereco.estado 
from Cliente inner join Endereco 
on Cliente.id_cliente = Endereco.id_endereco
;

