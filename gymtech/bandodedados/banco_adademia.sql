DROP SCHEMA public CASCADE;

CREATE SCHEMA public;


-- criando tabelas de usuarios, para acesso ao sistema

create table usuarios(
	id_user serial primary key,
	login varchar(50) unique not null,
	senha varchar(50) not null,
	permissao int not null
);

-- inserindo usuarios para teste de permissao

insert into usuarios (login, senha, permissao) values ('gymtech', 'gymtech', '0');
insert into usuarios (login, senha, permissao) values ('aluno', 'aluno', '1');
insert into usuarios (login, senha, permissao) values ('professor', 'professor', '2');
insert into usuarios (login, senha, permissao) values ('recepcao', 'recepcao', '3');

-- criando as tabelas


create table recepcao(
	id_recepcao serial primary key,
	nome varchar(150) not null,
	cpf varchar(11) not null,
	data_nasc date,
	id_user int,
	constraint id_user foreign key(id_user)
	references usuarios(id_user) match simple
);

create table professor(
	id_professor serial primary key,
	nome varchar(150) not null,
	cpf varchar(11) not null,
	data_nasc date,
	id_user int,
	constraint id_user foreign key(id_user)
	references usuarios(id_user) match simple
);

create table aluno(
	id_aluno serial primary key,
	nome varchar(150) not null,
	cpf varchar(11) not null,
	rg varchar(9) not null,
	endereco_rua varchar(150) not null,
	endereco_num varchar(10) not null,
	endereco_comp varchar(15),
	cep varchar(15) not null,
	bairro varchar(50) not null,
	data_nasc date,
	celular varchar(15),
	cad_recep int,
	constraint cad_recep foreign key(cad_recep)
	references recepcao(id_recepcao) match simple,
	id_user int,
	constraint id_user foreign key(id_user)
	references usuarios(id_user) match simple
);

create table treino_perna(
	id_perna serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_ombro(
	id_ombro serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_biceps(
	id_biceps serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_costas(
	id_costas serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_peito(
	id_peito serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_triceps(
	id_triceps serial primary key,
	nivel varchar(50) not null,
	exercicios text not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table ficha_treino(
	id_ficha serial primary key,
	aluno int,
	constraint aluno foreign key(aluno)
	references aluno(id_aluno) match simple,
	peso double precision not null,
	altura double precision not null,
	tipo_sang varchar(4) not null,
	t_perna int,
	constraint t_perna foreign key(t_perna)
	references treino_perna(id_perna) match simple,
	t_ombro int,
	constraint t_ombro foreign key(t_ombro)
	references treino_ombro(id_ombro) match simple,
	t_biceps int,
	constraint t_biceps foreign key(t_biceps)
	references treino_biceps(id_biceps) match simple,
	t_costas int,
	constraint t_costas foreign key(t_costas)
	references treino_costas(id_costas) match simple,
	t_peito int,
	constraint t_peito foreign key(t_peito)
	references treino_peito(id_peito) match simple,
	t_triceps int,
	constraint t_triceps foreign key(t_triceps)
	references treino_triceps(id_triceps) match simple
);