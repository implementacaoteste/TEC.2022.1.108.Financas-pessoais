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
	Ativo BIT,
	Renda FLOAT
)
GO

IF OBJECT_ID('Despesas', 'U') IS NULL
CREATE TABLE Despesas
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContasPagar INT,
	IdContato INT,
	IdBanco INT,
	IdFormaPagamento INT,
	Valor FLOAT,
	Descricao VARCHAR(250),
	DataEmissao DATE
)
GO

IF OBJECT_ID('Receita', 'U') IS NULL
CREATE TABLE Receita
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	IdContasReceber INT NULL,
	IdContato INT NULL,
	IdBanco INT NULL,
	IdFormaPagamento INT NULL,
	Valor FLOAT NULL,
	Descricao VARCHAR(250) NULL,
	DataEmissao DATE NULL
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
	DataEmissao DATE,
	DataPagamento DATE DEFAULT NULL
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
	DataEmissao DATE,
	DataPagamento DATE DEFAULT NULL
)
GO

IF OBJECT_ID('Contato', 'U') IS NULL
CREATE TABLE Contato
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Nome VARCHAR(150),
	Endereco VARCHAR(150),
	Numero VARCHAR(15),
	Descricao VARCHAR(250),
	Ativo BIT
)
GO

IF OBJECT_ID('FormaPagamento', 'U') IS NULL
CREATE TABLE FormaPagamento
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Descricao VARCHAR(250),
	Ativo BIT
)
GO

IF OBJECT_ID('Banco', 'U') IS NULL
CREATE TABLE Banco
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Nome VARCHAR(150),
	Saldo FLOAT,
	Poupanca FLOAT,
	Ativo BIT,
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

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Despesas') AND name = 'FK_Despesas_ContasPagar')
ALTER TABLE Despesas
ADD CONSTRAINT FK_Despesas_ContasPagar
FOREIGN KEY (IdContasPagar) REFERENCES ContasPagar(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Receita') AND name = 'FK_Receita_ContasReceber')
ALTER TABLE Receita
ADD CONSTRAINT FK_Receita_ContasReceber
FOREIGN KEY (IdContasReceber) REFERENCES ContasReceber(Id)

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

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Contato') AND name = 'FK_Contato_Usuario')
ALTER TABLE Contato
ADD CONSTRAINT FK_Contato_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Banco') AND name = 'FK_Banco_Usuario')
ALTER TABLE Banco
ADD CONSTRAINT FK_Banco_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('FormaPagamento') AND name = 'FK_FormaPagamento_Usuario')
ALTER TABLE FormaPagamento
ADD CONSTRAINT FK_FormaPagamento_Usuario
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

--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 1))INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 2))INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 3))INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 4))INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 5))INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 6))INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 7))INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 8))INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 9))INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permiss�o a um grupo de usu�rio')
--IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 10))INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usu�rio a um usu�rio')
--GO

--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Erisvaldo'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Erisvaldo Carvalho', 'Erisvaldo', '123456', 1)
--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Geno'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Genoveva', 'Geno', '1234', 1)
--IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Dag'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Dagorlina', 'Dag', '123456', 1)
--GO

INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda, Ativo)VALUES('Ana', 'Ana', 'wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=', 1400, 1)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda, Ativo)VALUES('Lucas', 'Lucas', 'wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=', 650, 1)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda, Ativo)VALUES('Maria', 'Maria', 'wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=', 800, 1)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda, Ativo)VALUES('Jo�o', 'Jo�o', 'wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=', 1000, 1)
INSERT INTO Usuario(Nome, NomeUsuario, Senha, Renda, Ativo)VALUES('Pedro', 'Pedro', 'wmKdvuWfY4e2P/EYguGYCbf/qc+vH6/f4VtX62USj+I=', 2000, 1)
GO

INSERT INTO Banco (Nome, Poupanca, Ativo, IdUsuario) VALUES('Inter', 50.5, 1, 1)
INSERT INTO Banco (Nome, Poupanca, Ativo, IdUsuario) VALUES('Nubank', 30.0, 1, 1)
INSERT INTO Banco (Nome, Poupanca, Ativo, IdUsuario) VALUES('Caixa', 10.5, 1, 1)
INSERT INTO Banco (Nome, Poupanca, Ativo, IdUsuario) VALUES('Banco do Brasil', 20.0, 1, 1)
GO

INSERT INTO Contato(Nome, Endereco, Numero, Descricao, Ativo, IdUsuario)VALUES('Gean', 'rua C', '63992929292', 'vizinho', 1, 1)
INSERT INTO Contato(Nome, Endereco, Numero, Descricao, Ativo, IdUsuario)VALUES('Alice', 'rua X', '1181818181', 'colega do servi�o', 1, 1)
INSERT INTO Contato(Nome, Endereco, Numero, Descricao, Ativo, IdUsuario)VALUES('Bruno', 'rua Z', '63991919191', 'irm�o', 1, 1)
INSERT INTO Contato(Nome, Endereco, Numero, Descricao, Ativo, IdUsuario)VALUES('Bruna', 'rua Jardim', '63992747474', 'colega de escola', 1, 1)
INSERT INTO Contato(Nome, Endereco, Numero, Descricao, Ativo, IdUsuario)VALUES('Marcelo', 'rua N', '63991121212', 'vizinha da m�e', 1, 1)
GO

INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Dinheiro',1,1)
INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Pix',1,1)
INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Cart�o',1,1)
INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Credito',1,1)
INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Tranfer�ncia',1,1)
INSERT INTO FormaPagamento(Descricao, IdUsuario, Ativo) VALUES('Boleto',1,1)
GO

--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)(SELECT 1, Id FROM Permissao)
--GO
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 1)
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 2)
--INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 3)
--GO
