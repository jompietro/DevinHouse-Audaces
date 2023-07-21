--COMANDO PARA CRIAÇÃO DE BANCO DE DADOS

 --CREATE DATABASE Audaces;

 --COMANDO PARA CRIAÇÃO DA TABELA Pessoa

 --COMANDO PARA UTILIZAR UM BANCO DE DADOS
 --USE Audaces 
 --GO

 CREATE TABLE Audaces.dbo.Pessoa
 (
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar(200) NOT NULL,
	Endereco varchar(200) NOT NULL,
	Cidade varchar(200) NULL
 );
 GO

 CREATE TABLE Audaces.dbo.Alunos 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),  
 Nome VARCHAR(100) NOT NULL,  
 Matricula VARCHAR(40) UNIQUE NOT NULL ,  
); 
GO
 
CREATE TABLE Audaces.dbo.Disciplinas 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),   
 Nome VARCHAR(200),  
); 
GO

CREATE TABLE Audaces.dbo.Alunos_Disciplina 
(  
 Id INT PRIMARY KEY IDENTITY(1,1),  
 DisciplinaId INT,  
 AlunoId INT NOT NULL,  
); 

ALTER TABLE Alunos_Disciplina ADD FOREIGN KEY(DisciplinaId) REFERENCES Disciplinas (Id)
ALTER TABLE Alunos_Disciplina ADD FOREIGN KEY(AlunoId) REFERENCES Alunos (Id)
GO
 
-----------------------------------------------------------------------------------
CREATE TABLE Audaces.dbo.Categorias 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),  
 Nome VARCHAR(200) NOT NULL,  
); 
GO

CREATE TABLE Audaces.dbo.Filmes 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),    
 Titulo VARCHAR(200) NOT NULL,  
 CategoriaId INT NOT NULL,  
); 
GO

CREATE TABLE Audaces.dbo.Atores 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),    
 Nome VARCHAR(200) NOT NULL,  
 Telefone VARCHAR(30) NOT NULL,  
 Endereco VARCHAR(200) NOT NULL,  
); 

CREATE TABLE Audaces.dbo.Filmes_Atores 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),    
 FilmeId INT NOT NULL,  
 AtorId INT,   
); 

CREATE TABLE Audaces.dbo.Clientes 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),    
 Nome VARCHAR(200) NOT NULL,  
 Endereco VARCHAR(200),  
); 

CREATE TABLE Audaces.dbo.LocadoraVideo 
( 
 Id INT PRIMARY KEY IDENTITY(1,1),    
 FilmeId INT NOT NULL,  
 ClienteId INT NOT NULL,  
); 

USE Audaces
GO

ALTER TABLE Filmes ADD FOREIGN KEY(CategoriaId) REFERENCES Categorias(Id)
ALTER TABLE Filmes_Atores ADD FOREIGN KEY(FilmeId) REFERENCES Filmes(Id)
ALTER TABLE Filmes_Atores ADD FOREIGN KEY(AtorId) REFERENCES Atores(Id)
ALTER TABLE LocadoraVideo ADD FOREIGN KEY(FilmeId) REFERENCES Filmes(Id)
ALTER TABLE LocadoraVideo ADD FOREIGN KEY(ClienteId) REFERENCES Clientes(Id)
-------------------------------------------------------------------------


create table Audaces.dbo.Enderecos (
	id INT PRIMARY KEY IDENTITY(1,1),
	rua VARCHAR(255) NOT NULL,
	numero INT,
	complemento VARCHAR(40) NOT NULL,
	bairro VARCHAR(80) NOT NULL,
	cidade VARCHAR(80) NOT NULL,
	uf CHAR(2) NOT NULL
);

create table Audaces.dbo.Pessoas (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(80) NOT NULL,
	sobrenome VARCHAR(80) NOT NULL,
	endereco_id INT REFERENCES Enderecos (id)
);


create table Audaces.dbo.Lojas (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(80) NOT NULL,
	descricao VARCHAR(255) NOT NULL,
	endereco_id INT,
	FOREIGN KEY (endereco_id) REFERENCES Enderecos (id)
);

--------------------------------------------------------------------
--CONSTRAINTS


--------------------------------------------------------------------
--ON CASCADE
CREATE TABLE Pai (
 ID INT PRIMARY KEY IDENTITY(1,1),
 Nome VARCHAR(50) NOT NULL
);


CREATE TABLE Filho (
 ID SMALLINT PRIMARY KEY IDENTITY(1,1),
 Nome  VARCHAR(50)  NOT NULL,
 ID_Pai INT NOT NULL,

 CONSTRAINT fk_id_pai FOREIGN KEY (ID_Pai)
 REFERENCES Pai(Id)
 ON DELETE CASCADE
 ON UPDATE CASCADE
);

INSERT INTO Pai VALUES ('João'), ('Mário'), ('Renato'), ('Emerson'), ('André');

INSERT INTO Filho (Nome, ID_Pai) VALUES ('João',1), ('Mário',1), ('Renato',3), ('Emerson',4), ('André',3);
