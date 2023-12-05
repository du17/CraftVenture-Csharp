DROP DATABASE if exists bd_venture;

create database IF NOT EXISTS BD_Venture;

use BD_Venture;

set FOREIGN_KEY_CHECKS = 0;

create table usuario(
id int auto_increment,
nome varchar(50) not null unique,
email varchar(50) not null unique,
senha varchar(20) not null,
primary key(id)
);

CREATE TABLE cliente(
id INT AUTO_INCREMENT UNIQUE,
nome VARCHAR(50) NOT NULL,
email VARCHAR(50) NOT NULL UNIQUE,
telefone varchar(15) NOT NULL,
cep VARCHAR(10) NOT NULL,
rua VARCHAR(100) NOT NULL,
bairro VARCHAR(50) NOT NULL,
numero INT NOT NULL,
cidade varchar(50),
estado VARCHAR(8) NOT NULL,
complemento VARCHAR(100),
PRIMARY KEY(id)
);

create table venda(
id int auto_increment unique,
nomeCliente varchar(50) not null,
formaPagamento varchar(20) not null,
formaEntrega varchar(30) not null,
valorTotal decimal(10, 2) not null,
anotacao varchar(100),
dataEntrega date not null,
dataVenda date not null,
idUsuario int not null,
codigoCliente int not null,
primary key(id),
foreign key (idUsuario) references usuario(id)
on update cascade
on delete cascade,
foreign key (codigoCliente) references cliente(id)
on update cascade
on delete cascade
);

create table produto(
id int auto_increment unique,
nome varchar(50) unique not null,
valor decimal(10, 2) not null,
tipo varchar(50) not null,
quantidade int not null,
foto longblob,
primary key(id)
);

create table vende(
id int auto_increment unique,
quantidade int not null,
idVenda int not null,
idProduto int not null,
primary key(id),
foreign key (idVenda) references venda(id)
on update cascade
on delete cascade,
foreign key (idProduto) references produto(id)
on update cascade
on delete cascade
);

create table tipoMaterial(
id int auto_increment unique,
nome varchar(50) not null,
primary key(id)
);

create table material(
id int auto_increment unique,
nome varchar(50) unique not null,
valor decimal(10,2) not null,
foto longblob,
idTipoMaterial int not null,
quantidade int,
primary key(id),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table MaterialProduto(
id int auto_increment unique,
idMaterial int not null,
idProduto int not null,
quantidade int,
primary key(id),
foreign key (idMaterial) references material(id)
on update cascade
on delete cascade,
foreign key (idProduto) references produto(id)
on update cascade
on delete cascade
);

create table papel(
idTipoMaterial int not null,
tipo varchar(20) not null,
gramatura char(3) not null,
cor varchar(10) not null,
tamanho char(2) not null,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table fita(
idTipoMaterial int not null,
tipo varchar(20) not null,
numero tinyint not null,
metragem decimal(20,2) not null,
marca varchar(15) not null,
numeroCor char(3) not null,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table perola(
idTipoMaterial int not null,
cor varchar(20) not null,
tamanho decimal(20,2) not null,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table tecido(
idTipoMaterial int not null,
tipo varchar(25) not null,
metragemAltura double not null,
metragemComprimento double not null,
tipoEstampa varchar(20) not null,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table renda(
idTipoMaterial int not null,
tamanho varchar(3),
metragem decimal(20,2),
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table acetato(
idTipoMaterial int not null,
espessura decimal(20,2) not null,
metragemAltura double not null,
metragemComprimento double not null,
foto longblob,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

create table canudo(
idTipoMaterial int not null,
cor varchar(10) not null,
quantidade smallint not null,
primary key(idTipoMaterial),
foreign key (idTipoMaterial) references tipoMaterial(id)
on update cascade
on delete cascade
);

/*select*/
SELECT CONCAT('ALTER TABLE `', table_name, '` CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;')
FROM information_schema.tables
WHERE table_schema = 'bd_venture';

SELECT TABLE_NAME, TABLE_COLLATION
FROM information_schema.tables
WHERE TABLE_SCHEMA = 'bd_venture' AND TABLE_NAME = 'acetato';

/*insert*/
/*('Papel'),
('Fita'),
('Pérola'),
('Tecido'),
('Renda'),
('Acetato'),
('Canudo');

INSERT INTO material (nome, valor, idTipoMaterial, quantidade) VALUES
('Papel Pólen Branco A4 144 ', 1.99, LAST_INSERT_ID(), 100),
('Papel Fotográfico Azul A6 125', 5.50, LAST_INSERT_ID(), 50),
('Acetato 122 Micra 2 X 2', 12.99, LAST_INSERT_ID(), 30),
('Pérola Branco 12cm', 129.99, LAST_INSERT_ID(), 10),
('Pérola Verde 12cm', 9.99, LAST_INSERT_ID(), 200),
('Canudo Azul 16 Canudo(s)', 7.50, LAST_INSERT_ID(), 75),
('Canudo Branco 16 Canudo(s) ', 0.99, LAST_INSERT_ID(), 150),
('Fita N° 14 N° Cor 12 12', 29.99, LAST_INSERT_ID(), 20),
('Renda N 16 m', 2.49, LAST_INSERT_ID(), 300),
('Tecido Tule Estampado 4 cm', 49.99, LAST_INSERT_ID(), 15);

INSERT INTO usuario (nome, email, senha) VALUES ('Cleber', 'cleber@gmail.com', 'senha123');
SET @lastUsuarioId = LAST_INSERT_ID();

insert into cliente values (default, 'Antônio', 'antoniomatheusrs22@gmail.com', '(19) 97132-3338', '05658-040', 'Rua José Cola Grossi', 'Jardim Leonor', '430', 'São Paulo', 'SP', 'Sei la');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Jorge', 'Depósito', 'Motoboy', 100.00, 'Anotacao1', '2024-01-20', '2023-11-01', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Papel', 19.99, 'Offset', 100);

insert into vende values (default, 5, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 1, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Fotográfico', '75', 'offset', 'A3');
insert into fita values (LAST_INSERT_ID(),'Cetim', '15', '10', 'a', '1');
insert into perola values (LAST_INSERT_ID(),'Branco', '8');
insert into tecido values (LAST_INSERT_ID(),'Tule', '5', '3', 'Estampado');
insert into renda values (LAST_INSERT_ID(),'N', '10.0');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'2', '5', '3');
insert into canudo values (LAST_INSERT_ID(),'Azul', '15');

insert into cliente values (default, 'Josias', 'oiasoini@gmail.com', '(99) 99999-9999', '07752-010', 'Rua Sebastiana Félix Ribeiro', 'Água Fria', '950', 'Cajamar', 'SP', 'gdfgsdfgds');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Cleber', 'Pix', 'Correio', 200.00, 'Anotacao2', '2024-02-29', '2023-12-02', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Fita', 79.99, 'Cetim', 50);

insert into vende values (default, 2, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 2, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Offset', '90', 'normal', 'A3');
insert into fita values (LAST_INSERT_ID(),'Gorgurão', '24', '20', 'b', '2');
insert into perola values (LAST_INSERT_ID(),'Azul', '5');
insert into tecido values (LAST_INSERT_ID(),'Fralda', '5', '3', 'Liso');
insert into renda values (LAST_INSERT_ID(),'P', '10.0');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'3', '6', '5');
insert into canudo values (LAST_INSERT_ID(),'Rosa', '56');

insert into cliente values (default, 'Rios', 'imgi0wgi@gmail.com', '(88) 88888-8888', '08502-070', 'Travessa Padre Anchieta', 'Jardim Ferrazense', '520', 'Ferraz de Vasconcelos', 'SP', 'Entrega urgente');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Ana', 'Cartão', 'Melhor envio', 300.00, 'Anotacao3', '2023-03-02', '2023-01-03', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Pérola', 1299.99, 'Atoalhado', 20);

insert into vende values (default, 10, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 3,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Colorplus', '108', 'amarelo', 'A5');
insert into fita values (LAST_INSERT_ID(),'Voil', '15', '14', 'c', '3');
insert into perola values (LAST_INSERT_ID(),'Rosa', '7');
insert into tecido values (LAST_INSERT_ID(),'Tricoline', '5', '3', 'Estampado');
insert into renda values (LAST_INSERT_ID(),'G', '5.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'6', '4', '6');
insert into canudo values (LAST_INSERT_ID(),'Preto', '86');

insert into cliente values (default, 'Airton', 'kjsdfnfnsfdn@gmail.com', '(77) 77777-7777', '14801-743', 'Rua Alfredo Rebuglio', 'Jardim Universal', '625', 'Araraquara', 'SP', 'ggdfgsd');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Rosa', 'Cartão', 'Motoboy', 400.00, 'Anotacao4', '2023-04-04', '2023-02-04', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Tecido', 149.99, 'P', 30);

insert into vende values (default, 3, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 4,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Offset', '90', 'offset', 'A3');
insert into fita values (LAST_INSERT_ID(),'Cetim', '15', '25', 'a', '2');
insert into perola values (LAST_INSERT_ID(),'Preto', '6');
insert into tecido values (LAST_INSERT_ID(),'Fralda', '5', '3', 'Liso');
insert into renda values (LAST_INSERT_ID(),'P', '6.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'2', '3', '2');
insert into canudo values (LAST_INSERT_ID(),'Branco', '54');

insert into cliente values (default, 'Fernanda', 'njuiniogniog@gmail.com', '(66) 66666-6666', '07152-070', 'Rua São Francisco DOeste', 'Parque Santos Dumont', '856', 'Guarulhos', 'SP', 'dsfsfsdg');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Cleusa', 'Pix', 'Correio', 500.00, 'Anotacao5','2023-05-10', '2023-03-05',  @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Renda', 89.99, '-', 40);

insert into vende values (default, 8, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 5,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Fotográfico', '90', 'rosa', 'A4');
insert into fita values (LAST_INSERT_ID(),'Gorgurão', '5', '15', 'b', '1');
insert into perola values (LAST_INSERT_ID() ,'Azul', '3');
insert into tecido values (LAST_INSERT_ID(),'feltro', '5', '3', 'Estampado');
insert into renda values (LAST_INSERT_ID(),'N', '8.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'1', '5', '3');
insert into canudo values (LAST_INSERT_ID(),'Cinza', '63');

insert into cliente values (default, 'Carlos', 'miokgomgooka@hotmail.com', '(55) 55555-5555', '05630-060', 'Rua Custódio Nunes', 'Vila Suzana', '785', 'São Paulo', 'SP', 'gdfgsdf');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Cleber', 'Catarão', 'Correio', 600.00, 'Anotacao6', '2023-06-13', '2023-04-06', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Acetato', 15.00, '-', 75);

insert into vende values (default, 4, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 6,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Colorplus', '75', 'offset', 'A4');
insert into fita values (LAST_INSERT_ID(),'Gorgurão', '12', '65', 'd', '1');
insert into perola values (LAST_INSERT_ID(),'Cinza', '5');
insert into tecido values (LAST_INSERT_ID(),'Atoalhado', '5', '3', 'Liso');
insert into renda values (LAST_INSERT_ID(),'N', '9.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'3', '2', '5');
insert into canudo values (LAST_INSERT_ID(),'Vermelho', '100');

insert into cliente values (default, 'Eduarda', 'njfofnofo@gmail.com', '(44) 44444-4444', '14169-436', 'Rua Antônio Ninin', 'Cidade Jardim','985', 'Sertãozinho', 'SP', 'dsgsdg');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Jaime', 'Depósito', 'Motoboy', 700.00, 'Anotacao7', '2023-07-12', '2023-05-07', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Canudo', 59.99, 'Fotográfico', 60);

insert into vende values (default, 6, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 7,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Offset', '108', 'normal', 'A3');
insert into fita values (LAST_INSERT_ID(),'Cetim', '16', '3', 'e', '3');
insert into perola values (LAST_INSERT_ID(),'Rosa', '6');
insert into tecido values (LAST_INSERT_ID(),'Fralda', '5', '3', 'Liso');
insert into renda values (LAST_INSERT_ID(),'P', '1.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'5', '1', '6');
insert into canudo values (LAST_INSERT_ID(),'Azul', '50');

insert into cliente values (default, 'Luan', 'oninoisnfoi@gmail.com', '(33) 33333-5555', '04728-020', 'Rua do Carreiro de Pedra', 'Jardim Caravelas', '496', 'São Paulo', 'SP', 'sfdfsdf');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Matheus', 'Pix', 'Melhor envio', 800.00, 'Anotacao8', '2023-08-15', '2023-06-08', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Acetat', 29.99, '--', 50);

insert into vende values (default, 1, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 8,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Fotográfico', '108', 'preto', 'A5');
insert into fita values (LAST_INSERT_ID(),'Voil', '2', '5', 'a', '3');
insert into perola values (LAST_INSERT_ID(),'Azul', '2');
insert into tecido values (LAST_INSERT_ID(),'Tricoline', '5', '3', 'Estampado');
insert into renda values (LAST_INSERT_ID(),'P', '5.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'1', '2', '7');
insert into canudo values (LAST_INSERT_ID(),'Rosa', '5');

insert into cliente values (default, 'Vinicius', 'ionjniufnfniao@gmail.com', '(22) 22222-2222', '02129-000', 'Rua Sargento Agostinho Ferreira', 'Vila Maria Alta', '653', 'São Paulo', 'SP', 'fdfdsf');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Paula', 'Cartão', 'Melhor envio', 900.00, 'Anotacao9', '2023-09-20', '2023-07-09', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Rend', 199.99, 'N', 15);

insert into vende values (default, 7, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 9,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Pólen', '75', 'azul', 'A3');
insert into fita values (LAST_INSERT_ID(),'Voil', '1', '8', 'b', '2');
insert into perola values (LAST_INSERT_ID(),'Branco', '4');
insert into tecido values (LAST_INSERT_ID(),'Fralda', '5', '3', 'Liso');
insert into renda values (LAST_INSERT_ID(),'G', '4.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'8', '4', '8');
insert into canudo values (LAST_INSERT_ID(),'Roda', '10');


insert into cliente values (default, 'Vitor', 'ereroeroeroi@gmail.com', '(11) 11111-1111', '06332-400', 'Rua Sucupira', 'Vila Veloso', '820', 'Carapicuíba', 'SP', 'fsfdsfd');
SET @lastClienteID = LAST_INSERT_ID();

insert into venda values (default, 'Paulo', 'Pix', 'Motoboy', 1000.00, 'Anotacao10', '2023-10-10', '2023-08-10', @lastUsuarioId, @lastClienteID);

insert into produto (id, nome, valor, tipo, quantidade) values (default, 'Canud', 12.50, '--', 120);

insert into vende values (default, 5, LAST_INSERT_ID(), LAST_INSERT_ID());

insert into MaterialProduto values (default, 10,LAST_INSERT_ID(), LAST_INSERT_ID());

insert into papel values (LAST_INSERT_ID(),'Offset', '90', 'offset', 'A5');
insert into fita values (LAST_INSERT_ID(),'Cetim', '2', '54', 'c', '1');
insert into perola values (LAST_INSERT_ID(),'Azul', '2');
insert into tecido values (LAST_INSERT_ID(),'Atoalhado', '5', '3', 'Estampado');
insert into renda values (LAST_INSERT_ID(),'G', '8.5');
insert into acetato (idTipoMaterial, espessura, metragemAltura, metragemComprimento) values (LAST_INSERT_ID(),'7', '3', '9');
insert into canudo values (LAST_INSERT_ID(),'Amarelo', '20');

set FOREIGN_KEY_CHECKS = 1;

select * from acetato*/