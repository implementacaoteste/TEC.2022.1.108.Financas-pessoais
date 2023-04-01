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
	Senha VARCHAR(50),
	Renda FLOAT
)
GO

IF OBJECT_ID('Despesas', 'U') IS NULL
CREATE TABLE Despesas
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Gastos FLOAT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('Receita', 'U') IS NULL
CREATE TABLE Receita
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Gastos FLOAT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('ContasPagar', 'U') IS NULL
CREATE TABLE ContasPagar
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	ValorPagar FLOAT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('ContasReceber', 'U') IS NULL
CREATE TABLE ContasReceber
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	ValorReceber FLOAT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('Contato', 'U') IS NULL
CREATE TABLE Contato
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdDespesas INT,
	IdReceita INT,
	IdcontasPagar INT,
	IdcontasReceber INT,
	Nome VARCHAR(150),
	Endereco VARCHAR(150),
	Numero INT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('FormaPagamento', 'U') IS NULL
CREATE TABLE FormaPagamento
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdDespesas INT,
	IdReceita INT,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('Banco', 'U') IS NULL
CREATE TABLE Banco
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdReceita INT,
	IdDespesas INT,
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

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Contato') AND name = 'FK_Contato_Despesas')
ALTER TABLE Contato
ADD CONSTRAINT FK_Contato_Despesas
FOREIGN KEY (IdDespesas) REFERENCES Despesas(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Contato') AND name = 'FK_Contato_Receita')
ALTER TABLE Contato
ADD CONSTRAINT FK_Contato_Receita
FOREIGN KEY (IdReceita) REFERENCES Receita(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Contato') AND name = 'FK_Contato_ContasPagar')
ALTER TABLE Contato
ADD CONSTRAINT FK_Contato_ContasPagar
FOREIGN KEY (IdContasPagar) REFERENCES ContasPagar(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Contato') AND name = 'FK_Contato_ContasReceber')
ALTER TABLE Contato
ADD CONSTRAINT FK_Contato_ContasReceber
FOREIGN KEY (IdContasReceber) REFERENCES ContasReceber(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('FormaPagamento') AND name = 'FK_FormaPagamento_Despesas')
ALTER TABLE FormaPagamento
ADD CONSTRAINT FK_FormaPagamento_Despesas
FOREIGN KEY (IdDespesas) REFERENCES Despesas(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('FormaPagamento') AND name = 'FK_FormaPagamento_Receita')
ALTER TABLE FormaPagamento
ADD CONSTRAINT FK_FormaPagamento_Receita
FOREIGN KEY (IdReceita) REFERENCES Receita(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Banco') AND name = 'FK_Banco_Receita')
ALTER TABLE Banco
ADD CONSTRAINT FK_Banco_Receita
FOREIGN KEY (IdReceita) REFERENCES Receita(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('Banco') AND name = 'FK_Banco_Despesas')
ALTER TABLE Banco
ADD CONSTRAINT FK_Banco_Despesas
FOREIGN KEY (IdDespesas) REFERENCES Despesas(Id)

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

--INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Gerente')
--INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Vendedor')
--INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Fiscal de caixa')
--INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Estoquista')
--INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Operador de caixa')

--GO
--INSERT INTO UsuarioGrupoUsuario VALUES(2,1)
--INSERT INTO UsuarioGrupoUsuario VALUES(1,2)
--GO

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