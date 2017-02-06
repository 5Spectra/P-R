create database PER

use PER

create table Jogador(
	id int identity primary key,
	nome varchar(100) not null,
	IDjogador int
)
drop table Jogador

select * from Jogador

insert into Jogador(nome) values('Amanda')
insert into Jogador(nome,IDjogador) values('Fernanda',1)

delete from Jogador

truncate table Jogador --mutila a tabela
truncate table TBPerguntas

alter table Jogador ADD IDjogador int;
alter table Jogador drop column IDjogador;

create table TBPerguntas(
	id int identity primary key,
	pergunta varchar(max),
	resposta_C varchar(max),
	data datetime default getdate(),
	id_jogador int)	

select * from TBPerguntas
select * from Jogador

insert into TBPerguntas(pergunta,resposta_C) values ('Quanto é 2 + 2?','4')

drop table TBPerguntas

select * from Jogador join TBPerguntas on Jogador.ID = TBPerguntas.id_jogador

select @@IDENTITY