USE master
GO

ALTER DATABASE Financias SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

DROP DATABASE Financias
GO

CREATE DATABASE Financias
GO

USE Financias
GO

IF OBJECT_ID('Usuario', 'U') IS NULL
CREATE TABLE Usuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	NomeUsuario VARCHAR(150),
	Senha VARCHAR(50),
	Renda FLOAT
)
GO

IF OBJECT_ID('Despesas', 'U') IS NULL
CREATE TABLE Despesas
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContato INT,
	IdBanco INT,
	IdFormaPagamento INT,
	Valor FLOAT,
	Descricao VARCHAR(250),
	DataEmissao VARCHAR(10)
)
GO

IF OBJECT_ID('Receita', 'U') IS NULL
CREATE TABLE Receita
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContato INT,
	IdBanco INT,
	IdFormaPagamento INT,
	Valor FLOAT,
	Descricao VARCHAR(250),
	DataEmissao VARCHAR(10)
)
GO

IF OBJECT_ID('ContasPagar', 'U') IS NULL
CREATE TABLE ContasPagar
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContato INT,
	IdBanco INT,
	IdFormaPagamento INT,
	ValorPagar FLOAT,
	Descricao VARCHAR(250),
	DataEmissao VARCHAR(10)
)
GO

IF OBJECT_ID('ContasReceber', 'U') IS NULL
CREATE TABLE ContasReceber
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContato INT,
	IdBanco INT,
	IdFormaPagamento INT,
	ValorReceber FLOAT,
	Descricao VARCHAR(250), 
	DataEmissao VARCHAR(10)
)
GO

IF OBJECT_ID('Contato', 'U') IS NULL
CREATE TABLE Contato
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	Endereco VARCHAR(150),
	Numero VARCHAR(11),
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('FormaPagamento', 'U') IS NULL
CREATE TABLE FormaPagamento
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('Banco', 'U') IS NULL
CREATE TABLE Banco
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	Saldo FLOAT,
	Poupanca FLOAT
)
GO

--IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE object_id = OBJECT_ID('Usuario') AND IS_PRIMARY_KEY = 1)
--ALTER TABLE Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY (Id)

--GO
--IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE object_id = OBJECT_ID('PermissaoGrupoUsuario') AND IS_PRIMARY_KEY = 1)
--ALTER TABLE PermissaoGrupoUsuario ADD CONSTRAINT PK_PermissaoGrupoUsuario PRIMARY KEY (IdPermissao, IdGrupoUsuario)

--GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Despesas') AND name = 'FK_Despesas_Usuario')
ALTER TABLE Despesas
ADD CONSTRAINT FK_Despesas_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Receita') AND name = 'FK_Receita_Usuario')
ALTER TABLE Receita
ADD CONSTRAINT FK_Receita_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasPagar') AND name = 'FK_ContasPagar_Usuario')
ALTER TABLE ContasPagar
ADD CONSTRAINT FK_ContasPagar_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasReceber') AND name = 'FK_ContasReceber_Usuario')
ALTER TABLE ContasReceber
ADD CONSTRAINT FK_ContasReceber_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Despesas') AND name = 'FK_Despesas_Contato')
ALTER TABLE Despesas
ADD CONSTRAINT FK_Despesas_Contato
FOREIGN KEY (IdContato) REFERENCES Contato(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Receita') AND name = 'FK_Receita_Contato')
ALTER TABLE Receita
ADD CONSTRAINT FK_Receita_Contato
FOREIGN KEY (IdContato) REFERENCES Contato(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasPagar') AND name = 'FK_ContasPagar_Contato')
ALTER TABLE ContasPagar
ADD CONSTRAINT FK_ContasPagar_Contato
FOREIGN KEY (IdContato) REFERENCES Contato(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasReceber') AND name = 'FK_ContasReceber_Contato')
ALTER TABLE ContasReceber
ADD CONSTRAINT FK_ContasReceber_Contato
FOREIGN KEY (IdContato) REFERENCES Contato(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Despesas') AND name = 'FK_Despesas_FormaPagamento')
ALTER TABLE Despesas
ADD CONSTRAINT FK_Despesas_FormaPagamento
FOREIGN KEY (IdFormaPagamento) REFERENCES FormaPagamento(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Receita') AND name = 'FK_Receita_FormaPagamento')
ALTER TABLE Receita
ADD CONSTRAINT FK_Receita_FormaPagamento
FOREIGN KEY (IdFormaPagamento) REFERENCES FormaPagamento(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasReceber') AND name = 'FK_ContasReceber_FormaPagamento')
ALTER TABLE ContasReceber
ADD CONSTRAINT FK_ContasReceber_FormaPagamento
FOREIGN KEY (IdFormaPagamento) REFERENCES FormaPagamento(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasPagar') AND name = 'FK_ContasPagar_FormaPagamento')
ALTER TABLE ContasPagar
ADD CONSTRAINT FK_ContasPagar_FormaPagamento
FOREIGN KEY (IdFormaPagamento) REFERENCES FormaPagamento(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Receita') AND name = 'FK_Receita_Banco')
ALTER TABLE Receita
ADD CONSTRAINT FK_Receita_Banco
FOREIGN KEY (Idbanco) REFERENCES Banco(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Despesas') AND name = 'FK_Despesas_Banco')
ALTER TABLE Despesas
ADD CONSTRAINT FK_Despesas_Banco
FOREIGN KEY (IdBanco) REFERENCES Banco(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasReceber') AND name = 'FK_ContasReceber_Banco')
ALTER TABLE ContasReceber
ADD CONSTRAINT FK_ContasReceber_Banco
FOREIGN KEY (IdBanco) REFERENCES Banco(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('ContasPagar') AND name = 'FK_ContasPagar_Banco')
ALTER TABLE ContasPagar
ADD CONSTRAINT FK_ContasPagar_Banco
FOREIGN KEY (IdBanco) REFERENCES Banco(Id)

GO

--IF COL_LENGTH('Usuario', 'DataCadastro') IS NULL
--ALTER TABLE Usuario ADD DataCadastro DATETIME DEFAULT GETDATE()

--GO

--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 1))INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 2))INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 3))INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 4))INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 5))INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 6))INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 7))INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 8))INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 9))INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permissão a um grupo de usuário')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 10))INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usuário a um usuário')
--GO

--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Erisvaldo'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Erisvaldo Carvalho', 'Erisvaldo', '123456', 1)
--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Geno'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Genoveva', 'Geno', '1234', 1)
--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Dag'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Dagorlina', 'Dag', '123456', 1)
--GO

INSERT INTO Banco (Nome, Saldo, Poupanca) VALUES('Inter', 500, 50.5)
INSERT INTO Banco (Nome, Saldo, Poupanca) VALUES('Nubank', 100.5, 30.0)
INSERT INTO Banco (Nome, Saldo, Poupanca) VALUES('Caixa', 150.0, 10.5)
INSERT INTO Banco (Nome, Saldo, Poupanca) VALUES('Banco do Brasil', 250.0, 20.0)
GO

INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda)VALUES('Ana', 'Ana', 123456, 1400)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda)VALUES('Lucas', 'Lucas', 123456, 650)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda)VALUES('Maria', 'Maria', 123456, 800)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda)VALUES('João', 'João', 123456, 1000)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda)VALUES('Pedro', 'Pedro', 123456, 2000)
GO

INSERT INTO Contato(Nome, Endereco, Numero, Descricao)VALUES('Gean', 'rua C', '63992929292', 'vizinho')
INSERT INTO Contato(Nome, Endereco, Numero, Descricao)VALUES('Alice', 'rua X', '1181818181', 'colega do serviço')
INSERT INTO Contato(Nome, Endereco, Numero, Descricao)VALUES('Bruno', 'rua Z', '63991919191', 'irmão')
INSERT INTO Contato(Nome, Endereco, Numero, Descricao)VALUES('Bruna', 'rua Jardim', '63992747474', 'colega de escola')
INSERT INTO Contato(Nome, Endereco, Numero, Descricao)VALUES('Marcelo', 'rua N', '63991121212', 'vizinha da mãe')
GO

--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,1)
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,2)
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,5)
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,2)
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,1)
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,5)
--GO

--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)(SELECT 1, Id FROM Permissao)
--GO
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 1)
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 2)
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 3)
--GO