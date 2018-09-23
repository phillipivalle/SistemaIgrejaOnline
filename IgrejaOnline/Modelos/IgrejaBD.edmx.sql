
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2018 20:05:58
-- Generated from EDMX file: C:\Users\Phillipi\Source\Repos\SistemaIgrejaOnline\IgrejaOnline\Modelos\IgrejaBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBIgreja];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DizimistasFinanceiro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FinanceiroSet] DROP CONSTRAINT [FK_DizimistasFinanceiro];
GO
IF OBJECT_ID(N'[dbo].[FK_IgrejasFinanceiro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FinanceiroSet] DROP CONSTRAINT [FK_IgrejasFinanceiro];
GO
IF OBJECT_ID(N'[dbo].[FK_IgrejasCultos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CultosSet] DROP CONSTRAINT [FK_IgrejasCultos];
GO
IF OBJECT_ID(N'[dbo].[FK_PastoresCultos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CultosSet] DROP CONSTRAINT [FK_PastoresCultos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DizimistasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DizimistasSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[PastoresSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PastoresSet];
GO
IF OBJECT_ID(N'[dbo].[IgrejasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IgrejasSet];
GO
IF OBJECT_ID(N'[dbo].[CultosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CultosSet];
GO
IF OBJECT_ID(N'[dbo].[FinanceiroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FinanceiroSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DizimistasSet'
CREATE TABLE [dbo].[DizimistasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNasci] datetime  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [Bairro] nvarchar(max)  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [UF] nvarchar(max)  NOT NULL,
    [NCartao] nvarchar(max)  NOT NULL,
    [Validade] datetime  NOT NULL,
    [CodSeguranca] nvarchar(max)  NOT NULL,
    [Salario] decimal(18,0)  NOT NULL,
    [NomeImpresso] nvarchar(max)  NOT NULL,
    [Bandeira] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Funcao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PastoresSet'
CREATE TABLE [dbo].[PastoresSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [PastorCPF] nvarchar(max)  NOT NULL,
    [PastorSexo] nvarchar(max)  NOT NULL,
    [DataNascPastor] datetime  NOT NULL,
    [EnderecoPastor] nvarchar(max)  NOT NULL,
    [NumeroPastor] int  NOT NULL,
    [CEPPastor] nvarchar(max)  NOT NULL,
    [BairroPastor] nvarchar(max)  NOT NULL,
    [CidadePastor] nvarchar(max)  NOT NULL,
    [UFPastor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IgrejasSet'
CREATE TABLE [dbo].[IgrejasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomeIgreja] nvarchar(max)  NOT NULL,
    [EnderecoIgreja] nvarchar(max)  NOT NULL,
    [NumeroIgreja] int  NOT NULL,
    [BairroIgreja] nvarchar(max)  NOT NULL,
    [UFIgreja] nvarchar(max)  NOT NULL,
    [CNPJIgreja] nvarchar(max)  NOT NULL,
    [SiteIgreja] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CultosSet'
CREATE TABLE [dbo].[CultosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataCulto] datetime  NOT NULL,
    [HorarioCulto] nvarchar(max)  NOT NULL,
    [LocalCulto] nvarchar(max)  NOT NULL,
    [PastorCulto] nvarchar(max)  NOT NULL,
    [PastoresId] int  NOT NULL,
    [Igrejas_Id] int  NOT NULL
);
GO

-- Creating table 'FinanceiroSet'
CREATE TABLE [dbo].[FinanceiroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SaldoTot] nvarchar(max)  NOT NULL,
    [ValorDoado] decimal(18,0)  NOT NULL,
    [DizimistaDoador] nvarchar(max)  NOT NULL,
    [IgrejaBeneficiada] nvarchar(max)  NOT NULL,
    [Dizimistas_Id] int  NOT NULL,
    [Igrejas_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DizimistasSet'
ALTER TABLE [dbo].[DizimistasSet]
ADD CONSTRAINT [PK_DizimistasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PastoresSet'
ALTER TABLE [dbo].[PastoresSet]
ADD CONSTRAINT [PK_PastoresSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IgrejasSet'
ALTER TABLE [dbo].[IgrejasSet]
ADD CONSTRAINT [PK_IgrejasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CultosSet'
ALTER TABLE [dbo].[CultosSet]
ADD CONSTRAINT [PK_CultosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FinanceiroSet'
ALTER TABLE [dbo].[FinanceiroSet]
ADD CONSTRAINT [PK_FinanceiroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Dizimistas_Id] in table 'FinanceiroSet'
ALTER TABLE [dbo].[FinanceiroSet]
ADD CONSTRAINT [FK_DizimistasFinanceiro]
    FOREIGN KEY ([Dizimistas_Id])
    REFERENCES [dbo].[DizimistasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DizimistasFinanceiro'
CREATE INDEX [IX_FK_DizimistasFinanceiro]
ON [dbo].[FinanceiroSet]
    ([Dizimistas_Id]);
GO

-- Creating foreign key on [Igrejas_Id] in table 'FinanceiroSet'
ALTER TABLE [dbo].[FinanceiroSet]
ADD CONSTRAINT [FK_IgrejasFinanceiro]
    FOREIGN KEY ([Igrejas_Id])
    REFERENCES [dbo].[IgrejasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IgrejasFinanceiro'
CREATE INDEX [IX_FK_IgrejasFinanceiro]
ON [dbo].[FinanceiroSet]
    ([Igrejas_Id]);
GO

-- Creating foreign key on [Igrejas_Id] in table 'CultosSet'
ALTER TABLE [dbo].[CultosSet]
ADD CONSTRAINT [FK_IgrejasCultos]
    FOREIGN KEY ([Igrejas_Id])
    REFERENCES [dbo].[IgrejasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IgrejasCultos'
CREATE INDEX [IX_FK_IgrejasCultos]
ON [dbo].[CultosSet]
    ([Igrejas_Id]);
GO

-- Creating foreign key on [PastoresId] in table 'CultosSet'
ALTER TABLE [dbo].[CultosSet]
ADD CONSTRAINT [FK_PastoresCultos]
    FOREIGN KEY ([PastoresId])
    REFERENCES [dbo].[PastoresSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PastoresCultos'
CREATE INDEX [IX_FK_PastoresCultos]
ON [dbo].[CultosSet]
    ([PastoresId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------