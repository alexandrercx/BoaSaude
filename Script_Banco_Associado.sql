USE [BoaSaude_Associado]
GO

/****** Object:  Table [dbo].[Associado]    Script Date: 23/02/2022 20:51:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Associado](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CPF] bigint NOT NULL,
	[DataNascimento] date NOT NULL,
	[NomeMae]  [varchar](100) NOT NULL,
	[CNS] bigint NULL,
	[PisPasep] bigint NULL,
	[Email] [varchar](100) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Associado] ADD TitularId [bigint] null

ALTER TABLE [Associado] ADD CONSTRAINT FK_Associado_Titular FOREIGN KEY (TitularId) REFERENCES Associado(Id);


--===========================================
CREATE TABLE [dbo].[Plano](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[ValorBase] decimal(10,2)
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO PLANO VALUES('Saúde - Básico', 50.00)
INSERT INTO PLANO VALUES('Saúde - Intermediário', 100.00)

--==========================

CREATE TABLE [dbo].[PlanoFaixaEtaria](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PlanoId] [bigint] not null,
	[IdadeInicial] int not null,
	[IdadeFinal] int not null,
	[ValorAdicional] decimal(10,2)
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [PlanoFaixaEtaria] ADD CONSTRAINT FK_PlanoFaixaEtaria_Plano FOREIGN KEY (PlanoId) REFERENCES Plano(Id);

INSERT INTO [PlanoFaixaEtaria] VALUES(1, 30,39,20.00)
INSERT INTO [PlanoFaixaEtaria] VALUES(1, 40,49,40.00)


--===================================

CREATE TABLE [dbo].[AssociadoPlano](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[AssociadoId] [bigint] not null,
	[PlanoId] [bigint] not null,
	[PlanoFaixaEtariaId] [bigint] null,
	[ValorContratado] decimal(10,2),
	[DataAtivacao] date not null,
	[DataInativacao] date null
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [AssociadoPlano] ADD CONSTRAINT FK_AssociadoPlano_Associado FOREIGN KEY (AssociadoId) REFERENCES Associado(Id);
ALTER TABLE [AssociadoPlano] ADD CONSTRAINT FK_AssociadoPlano_Plano FOREIGN KEY (PlanoId) REFERENCES Plano(Id);
ALTER TABLE [AssociadoPlano] ADD CONSTRAINT FK_AssociadoPlano_PlanoFaixaEtaria FOREIGN KEY ([PlanoFaixaEtariaId]) REFERENCES [PlanoFaixaEtaria](Id);

--=============================

CREATE TABLE [dbo].[Endereco](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoEndereco] bigint not null,
	[AssociadoId] [bigint] not null,
	[Logradouro] varchar(250) not null,
	[Numero] varchar(50) not null,
	[Bairro] varchar(250) not null,
	[Cidade] varchar(250) not null,
	[CEP] varchar(50) not null,
	[UF] varchar(2) not null,
	[Complemento] varchar(250) null,
	[Pais] varchar(250) not null
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Endereco] ADD CONSTRAINT FK_Endereco_Associado FOREIGN KEY (AssociadoId) REFERENCES Associado(Id);


--=============================

CREATE TABLE [dbo].[Telefone](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[AssociadoId] [bigint] not null,
	[TipoTelefone] int not null,
	[DDI] varchar(3) not null,
	[DDD] varchar(3) not null,
	[Numero] varchar(50) not null
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Telefone] ADD CONSTRAINT FK_Telefone_Associado FOREIGN KEY (AssociadoId) REFERENCES Associado(Id);


--=============================

CREATE TABLE [dbo].[ContaBanco](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[AssociadoId] [bigint] not null,
	[BancoId] int not null,
	[Agencia] varchar(10) not null,
	[DigitoAgencia] varchar(2) null,
	[Conta] varchar(20) not null,
	[DigitoConta] varchar(2) null,
	[TipoConta] varchar(50) not null
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [ContaBanco] ADD CONSTRAINT FK_ContaBanco_Associado FOREIGN KEY (AssociadoId) REFERENCES Associado(Id);
