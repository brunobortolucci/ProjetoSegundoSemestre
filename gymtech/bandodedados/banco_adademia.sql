DROP SCHEMA public CASCADE;

CREATE SCHEMA public;


-- criando tabelas de usuarios, para acesso ao sistema
-- permissoes, admin = 0, professor = 1, aluno = 2;

create table usuarios(
	id_user serial primary key,
	login varchar(50) unique not null,
	senha varchar(50) not null,
	permissao int not null
);

-- inserindo usuarios para teste de permissao

insert into usuarios (login, senha, permissao) values ('gymtech', 'gymtech', '0');
insert into usuarios (login, senha, permissao) values ('aluno', 'aluno', '2');
insert into usuarios (login, senha, permissao) values ('professor', 'professor', '1');
--insert into usuarios (login, senha, permissao) values ('bruno', 'bruno', '1');
--insert into professor (nome, cpf, data_nasc) values ('Bruno', '42814250809', '01/02/1992') returning id, professor);
-- criando as tabelas

create table administrador(
	id_admin serial primary key,
	nome varchar(150) not null,
	id_user int,
	constraint id_user foreign key(id_user)
	references usuarios(id_user) match simple
);

insert into administrador(nome, id_user) values('Administrador', '1');


create table professor(
	id_professor serial primary key,
	nome varchar(150) not null,
	cpf varchar(11) unique not null,
	data_nasc varchar(30),
	id_user int,
	foreign key(id_user)
	references usuarios(id_user) match simple
);

insert into professor(nome, cpf, data_nasc, id_user) values('Professor', '42014450090', '01/01/1990', '3');

create table aluno(
	id_aluno serial primary key,
	nome varchar(150) not null,
	cpf varchar(11) unique not null,
	rg varchar(9) unique not null,
	endereco_rua varchar(150) not null,
	endereco_num varchar(10) not null,
	endereco_comp varchar(15),
	cep varchar(15) not null,
	bairro varchar(50) not null,
	data_nasc varchar(50),
	celular varchar(15),
	id_user int,
	constraint id_user foreign key(id_user)
	references usuarios(id_user) match simple
);

insert into aluno(nome, cpf, rg, endereco_rua, endereco_num, endereco_comp, cep, bairro, data_nasc, celular, id_user)
values ('Aluno', '42010050809', '483002220', 'Avenida Sao Jose dos Campos', '3175', '', '13040735', 'Pq Sao Martinho', '01/02/1992', '19995054631', '2');

create table treino_perna(
	id_perna serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_ombro(
	id_ombro serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_biceps(
	id_biceps serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_costas(
	id_costas serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_peito(
	id_peito serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table treino_triceps(
	id_triceps serial primary key,
	nivel varchar(50) not null,
	exercicios varchar(50) not null,
	peso double precision not null,
	series int not null,
	repeticoes int not null
);

create table ficha_treino(
	id_ficha serial primary key,
	nome varchar(50) not null,
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

select id_user from usuarios where login = 'gymtech';

select senha from usuarios where senha = 'gymtech';

select max(id_user) from usuarios;

select * from usuarios;
select * from professor;
select * from aluno;

select * from treino_perna;
select * from treino_costas;
select * from treino_biceps;
select * from treino_peito;
select * from treino_ombro;
select * from treino_triceps;

select exercicios from treino_perna;

select * from ficha_treino;