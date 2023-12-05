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
