create database dbprojetoVersat1
default character set utf8mb4
default collate utf8mb4_general_ci;

use dbprojetoVersat1;

create table if not exists clientes (
	id int not null auto_increment primary key,
    nome varchar(40) not null,
    email varchar(40) not null,
    cpf varchar(11) not null,
    endereco varchar(40) not null
)default char set utf8mb4;
    
SELECT * FROM clientes;
