
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 17:03:14
-- Generated from EDMX file: C:\Users\S\Desktop\Baze projekat\ProjekatBaze\ProjekatBaze\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TeretanaBaza];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TeratanaOpremaUteretani]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OpremaUteretanis] DROP CONSTRAINT [FK_TeratanaOpremaUteretani];
GO
IF OBJECT_ID(N'[dbo].[FK_UzimaCasTreninga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Uzimas] DROP CONSTRAINT [FK_UzimaCasTreninga];
GO
IF OBJECT_ID(N'[dbo].[FK_UzimaClan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Uzimas] DROP CONSTRAINT [FK_UzimaClan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClanOpremaUteretani]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clans] DROP CONSTRAINT [FK_ClanOpremaUteretani];
GO
IF OBJECT_ID(N'[dbo].[FK_IdeTeratana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ides] DROP CONSTRAINT [FK_IdeTeratana];
GO
IF OBJECT_ID(N'[dbo].[FK_IdeClan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ides] DROP CONSTRAINT [FK_IdeClan];
GO
IF OBJECT_ID(N'[dbo].[FK_ProbniTreningTeratana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProbniTrenings] DROP CONSTRAINT [FK_ProbniTreningTeratana];
GO
IF OBJECT_ID(N'[dbo].[FK_ProbniTreningObicanVezbac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProbniTrenings] DROP CONSTRAINT [FK_ProbniTreningObicanVezbac];
GO
IF OBJECT_ID(N'[dbo].[FK_OpremaUteretaniObicanVezbac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObicanVezbacs] DROP CONSTRAINT [FK_OpremaUteretaniObicanVezbac];
GO
IF OBJECT_ID(N'[dbo].[FK_RadiTeratana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Radis] DROP CONSTRAINT [FK_RadiTeratana];
GO
IF OBJECT_ID(N'[dbo].[FK_RadiZaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Radis] DROP CONSTRAINT [FK_RadiZaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_CistiTeratana]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cistis] DROP CONSTRAINT [FK_CistiTeratana];
GO
IF OBJECT_ID(N'[dbo].[FK_CistiCistacica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cistis] DROP CONSTRAINT [FK_CistiCistacica];
GO
IF OBJECT_ID(N'[dbo].[FK_DrziTrener]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Drzis] DROP CONSTRAINT [FK_DrziTrener];
GO
IF OBJECT_ID(N'[dbo].[FK_DrziCasTreninga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Drzis] DROP CONSTRAINT [FK_DrziCasTreninga];
GO
IF OBJECT_ID(N'[dbo].[FK_TeratanaMenadzer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teratanas] DROP CONSTRAINT [FK_TeratanaMenadzer];
GO
IF OBJECT_ID(N'[dbo].[FK_TrenerOpremaUteretani]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenis_Trener] DROP CONSTRAINT [FK_TrenerOpremaUteretani];
GO
IF OBJECT_ID(N'[dbo].[FK_Cistacica_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenis_Cistacica] DROP CONSTRAINT [FK_Cistacica_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Trener_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenis_Trener] DROP CONSTRAINT [FK_Trener_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Menadzer_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenis_Menadzer] DROP CONSTRAINT [FK_Menadzer_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Recepcionista_inherits_Zaposleni]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zaposlenis_Recepcionista] DROP CONSTRAINT [FK_Recepcionista_inherits_Zaposleni];
GO
IF OBJECT_ID(N'[dbo].[FK_Sprave_inherits_OpremaUteretani]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OpremaUteretanis_Sprave] DROP CONSTRAINT [FK_Sprave_inherits_OpremaUteretani];
GO
IF OBJECT_ID(N'[dbo].[FK_Tegovi_inherits_OpremaUteretani]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OpremaUteretanis_Tegovi] DROP CONSTRAINT [FK_Tegovi_inherits_OpremaUteretani];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CasTreningas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CasTreningas];
GO
IF OBJECT_ID(N'[dbo].[Clans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clans];
GO
IF OBJECT_ID(N'[dbo].[OpremaUteretanis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OpremaUteretanis];
GO
IF OBJECT_ID(N'[dbo].[Teratanas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teratanas];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenis];
GO
IF OBJECT_ID(N'[dbo].[ObicanVezbacs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObicanVezbacs];
GO
IF OBJECT_ID(N'[dbo].[Uzimas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Uzimas];
GO
IF OBJECT_ID(N'[dbo].[Ides]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ides];
GO
IF OBJECT_ID(N'[dbo].[ProbniTrenings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProbniTrenings];
GO
IF OBJECT_ID(N'[dbo].[Radis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Radis];
GO
IF OBJECT_ID(N'[dbo].[Cistis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cistis];
GO
IF OBJECT_ID(N'[dbo].[Drzis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drzis];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenis_Cistacica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenis_Cistacica];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenis_Trener]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenis_Trener];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenis_Menadzer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenis_Menadzer];
GO
IF OBJECT_ID(N'[dbo].[Zaposlenis_Recepcionista]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zaposlenis_Recepcionista];
GO
IF OBJECT_ID(N'[dbo].[OpremaUteretanis_Sprave]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OpremaUteretanis_Sprave];
GO
IF OBJECT_ID(N'[dbo].[OpremaUteretanis_Tegovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OpremaUteretanis_Tegovi];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CasTreningas'
CREATE TABLE [dbo].[CasTreningas] (
    [IdCasTreninga] int IDENTITY(1,1) NOT NULL,
    [DatumIVreme] datetime  NOT NULL,
    [BrojClanova] int  NOT NULL
);
GO

-- Creating table 'Clans'
CREATE TABLE [dbo].[Clans] (
    [Kartica] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [OpremaZaVezbanje] int  NOT NULL,
    [OpremaUteretaniIdOprema] int  NULL
);
GO

-- Creating table 'OpremaUteretanis'
CREATE TABLE [dbo].[OpremaUteretanis] (
    [IdOprema] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Kolicina] int  NOT NULL,
    [TeratanaLokacija] int  NOT NULL
);
GO

-- Creating table 'Teratanas'
CREATE TABLE [dbo].[Teratanas] (
    [Lokacija] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [BrojTelefona] int  NOT NULL,
    [MenadzerIdBedz] int  NULL
);
GO

-- Creating table 'Zaposlenis'
CREATE TABLE [dbo].[Zaposlenis] (
    [IdBedz] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [Tip] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ObicanVezbacs'
CREATE TABLE [dbo].[ObicanVezbacs] (
    [IdObicanVezbac] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [OpremaZaVezbanje] int  NOT NULL,
    [OpremaUteretaniIdOprema] int  NULL
);
GO

-- Creating table 'Uzimas'
CREATE TABLE [dbo].[Uzimas] (
    [CasTreningaIdCasTreninga] int  NOT NULL,
    [ClanKartica] int  NOT NULL
);
GO

-- Creating table 'Ides'
CREATE TABLE [dbo].[Ides] (
    [TeratanaLokacija] int  NOT NULL,
    [ClanKartica] int  NOT NULL
);
GO

-- Creating table 'ProbniTrenings'
CREATE TABLE [dbo].[ProbniTrenings] (
    [TeratanaLokacija] int  NOT NULL,
    [ObicanVezbacIdObicanVezbac] int  NOT NULL
);
GO

-- Creating table 'Radis'
CREATE TABLE [dbo].[Radis] (
    [TeratanaLokacija] int  NOT NULL,
    [ZaposleniIdBedz] int  NOT NULL
);
GO

-- Creating table 'Cistis'
CREATE TABLE [dbo].[Cistis] (
    [TeratanaLokacija] int  NOT NULL,
    [CistacicaIdBedz] int  NOT NULL
);
GO

-- Creating table 'Drzis'
CREATE TABLE [dbo].[Drzis] (
    [TrenerIdBedz] int  NOT NULL,
    [CasTreningaIdCasTreninga] int  NOT NULL
);
GO

-- Creating table 'Zaposlenis_Cistacica'
CREATE TABLE [dbo].[Zaposlenis_Cistacica] (
    [IdBedz] int  NOT NULL
);
GO

-- Creating table 'Zaposlenis_Trener'
CREATE TABLE [dbo].[Zaposlenis_Trener] (
    [Sertifikat] nvarchar(max)  NOT NULL,
    [OpremaUteretaniIdOprema] int  NULL,
    [IdBedz] int  NOT NULL
);
GO

-- Creating table 'Zaposlenis_Menadzer'
CREATE TABLE [dbo].[Zaposlenis_Menadzer] (
    [IdBedz] int  NOT NULL
);
GO

-- Creating table 'Zaposlenis_Recepcionista'
CREATE TABLE [dbo].[Zaposlenis_Recepcionista] (
    [IdBedz] int  NOT NULL
);
GO

-- Creating table 'OpremaUteretanis_Sprave'
CREATE TABLE [dbo].[OpremaUteretanis_Sprave] (
    [DeoTela] nvarchar(max)  NOT NULL,
    [IdOprema] int  NOT NULL
);
GO

-- Creating table 'OpremaUteretanis_Tegovi'
CREATE TABLE [dbo].[OpremaUteretanis_Tegovi] (
    [Tezina] int  NOT NULL,
    [IdOprema] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCasTreninga] in table 'CasTreningas'
ALTER TABLE [dbo].[CasTreningas]
ADD CONSTRAINT [PK_CasTreningas]
    PRIMARY KEY CLUSTERED ([IdCasTreninga] ASC);
GO

-- Creating primary key on [Kartica] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [PK_Clans]
    PRIMARY KEY CLUSTERED ([Kartica] ASC);
GO

-- Creating primary key on [IdOprema] in table 'OpremaUteretanis'
ALTER TABLE [dbo].[OpremaUteretanis]
ADD CONSTRAINT [PK_OpremaUteretanis]
    PRIMARY KEY CLUSTERED ([IdOprema] ASC);
GO

-- Creating primary key on [Lokacija] in table 'Teratanas'
ALTER TABLE [dbo].[Teratanas]
ADD CONSTRAINT [PK_Teratanas]
    PRIMARY KEY CLUSTERED ([Lokacija] ASC);
GO

-- Creating primary key on [IdBedz] in table 'Zaposlenis'
ALTER TABLE [dbo].[Zaposlenis]
ADD CONSTRAINT [PK_Zaposlenis]
    PRIMARY KEY CLUSTERED ([IdBedz] ASC);
GO

-- Creating primary key on [IdObicanVezbac] in table 'ObicanVezbacs'
ALTER TABLE [dbo].[ObicanVezbacs]
ADD CONSTRAINT [PK_ObicanVezbacs]
    PRIMARY KEY CLUSTERED ([IdObicanVezbac] ASC);
GO

-- Creating primary key on [CasTreningaIdCasTreninga], [ClanKartica] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [PK_Uzimas]
    PRIMARY KEY CLUSTERED ([CasTreningaIdCasTreninga], [ClanKartica] ASC);
GO

-- Creating primary key on [TeratanaLokacija], [ClanKartica] in table 'Ides'
ALTER TABLE [dbo].[Ides]
ADD CONSTRAINT [PK_Ides]
    PRIMARY KEY CLUSTERED ([TeratanaLokacija], [ClanKartica] ASC);
GO

-- Creating primary key on [TeratanaLokacija], [ObicanVezbacIdObicanVezbac] in table 'ProbniTrenings'
ALTER TABLE [dbo].[ProbniTrenings]
ADD CONSTRAINT [PK_ProbniTrenings]
    PRIMARY KEY CLUSTERED ([TeratanaLokacija], [ObicanVezbacIdObicanVezbac] ASC);
GO

-- Creating primary key on [TeratanaLokacija], [ZaposleniIdBedz] in table 'Radis'
ALTER TABLE [dbo].[Radis]
ADD CONSTRAINT [PK_Radis]
    PRIMARY KEY CLUSTERED ([TeratanaLokacija], [ZaposleniIdBedz] ASC);
GO

-- Creating primary key on [TeratanaLokacija], [CistacicaIdBedz] in table 'Cistis'
ALTER TABLE [dbo].[Cistis]
ADD CONSTRAINT [PK_Cistis]
    PRIMARY KEY CLUSTERED ([TeratanaLokacija], [CistacicaIdBedz] ASC);
GO

-- Creating primary key on [TrenerIdBedz], [CasTreningaIdCasTreninga] in table 'Drzis'
ALTER TABLE [dbo].[Drzis]
ADD CONSTRAINT [PK_Drzis]
    PRIMARY KEY CLUSTERED ([TrenerIdBedz], [CasTreningaIdCasTreninga] ASC);
GO

-- Creating primary key on [IdBedz] in table 'Zaposlenis_Cistacica'
ALTER TABLE [dbo].[Zaposlenis_Cistacica]
ADD CONSTRAINT [PK_Zaposlenis_Cistacica]
    PRIMARY KEY CLUSTERED ([IdBedz] ASC);
GO

-- Creating primary key on [IdBedz] in table 'Zaposlenis_Trener'
ALTER TABLE [dbo].[Zaposlenis_Trener]
ADD CONSTRAINT [PK_Zaposlenis_Trener]
    PRIMARY KEY CLUSTERED ([IdBedz] ASC);
GO

-- Creating primary key on [IdBedz] in table 'Zaposlenis_Menadzer'
ALTER TABLE [dbo].[Zaposlenis_Menadzer]
ADD CONSTRAINT [PK_Zaposlenis_Menadzer]
    PRIMARY KEY CLUSTERED ([IdBedz] ASC);
GO

-- Creating primary key on [IdBedz] in table 'Zaposlenis_Recepcionista'
ALTER TABLE [dbo].[Zaposlenis_Recepcionista]
ADD CONSTRAINT [PK_Zaposlenis_Recepcionista]
    PRIMARY KEY CLUSTERED ([IdBedz] ASC);
GO

-- Creating primary key on [IdOprema] in table 'OpremaUteretanis_Sprave'
ALTER TABLE [dbo].[OpremaUteretanis_Sprave]
ADD CONSTRAINT [PK_OpremaUteretanis_Sprave]
    PRIMARY KEY CLUSTERED ([IdOprema] ASC);
GO

-- Creating primary key on [IdOprema] in table 'OpremaUteretanis_Tegovi'
ALTER TABLE [dbo].[OpremaUteretanis_Tegovi]
ADD CONSTRAINT [PK_OpremaUteretanis_Tegovi]
    PRIMARY KEY CLUSTERED ([IdOprema] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeratanaLokacija] in table 'OpremaUteretanis'
ALTER TABLE [dbo].[OpremaUteretanis]
ADD CONSTRAINT [FK_TeratanaOpremaUteretani]
    FOREIGN KEY ([TeratanaLokacija])
    REFERENCES [dbo].[Teratanas]
        ([Lokacija])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeratanaOpremaUteretani'
CREATE INDEX [IX_FK_TeratanaOpremaUteretani]
ON [dbo].[OpremaUteretanis]
    ([TeratanaLokacija]);
GO

-- Creating foreign key on [CasTreningaIdCasTreninga] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [FK_UzimaCasTreninga]
    FOREIGN KEY ([CasTreningaIdCasTreninga])
    REFERENCES [dbo].[CasTreningas]
        ([IdCasTreninga])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ClanKartica] in table 'Uzimas'
ALTER TABLE [dbo].[Uzimas]
ADD CONSTRAINT [FK_UzimaClan]
    FOREIGN KEY ([ClanKartica])
    REFERENCES [dbo].[Clans]
        ([Kartica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UzimaClan'
CREATE INDEX [IX_FK_UzimaClan]
ON [dbo].[Uzimas]
    ([ClanKartica]);
GO

-- Creating foreign key on [OpremaUteretaniIdOprema] in table 'Clans'
ALTER TABLE [dbo].[Clans]
ADD CONSTRAINT [FK_ClanOpremaUteretani]
    FOREIGN KEY ([OpremaUteretaniIdOprema])
    REFERENCES [dbo].[OpremaUteretanis]
        ([IdOprema])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClanOpremaUteretani'
CREATE INDEX [IX_FK_ClanOpremaUteretani]
ON [dbo].[Clans]
    ([OpremaUteretaniIdOprema]);
GO

-- Creating foreign key on [TeratanaLokacija] in table 'Ides'
ALTER TABLE [dbo].[Ides]
ADD CONSTRAINT [FK_IdeTeratana]
    FOREIGN KEY ([TeratanaLokacija])
    REFERENCES [dbo].[Teratanas]
        ([Lokacija])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ClanKartica] in table 'Ides'
ALTER TABLE [dbo].[Ides]
ADD CONSTRAINT [FK_IdeClan]
    FOREIGN KEY ([ClanKartica])
    REFERENCES [dbo].[Clans]
        ([Kartica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdeClan'
CREATE INDEX [IX_FK_IdeClan]
ON [dbo].[Ides]
    ([ClanKartica]);
GO

-- Creating foreign key on [TeratanaLokacija] in table 'ProbniTrenings'
ALTER TABLE [dbo].[ProbniTrenings]
ADD CONSTRAINT [FK_ProbniTreningTeratana]
    FOREIGN KEY ([TeratanaLokacija])
    REFERENCES [dbo].[Teratanas]
        ([Lokacija])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ObicanVezbacIdObicanVezbac] in table 'ProbniTrenings'
ALTER TABLE [dbo].[ProbniTrenings]
ADD CONSTRAINT [FK_ProbniTreningObicanVezbac]
    FOREIGN KEY ([ObicanVezbacIdObicanVezbac])
    REFERENCES [dbo].[ObicanVezbacs]
        ([IdObicanVezbac])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProbniTreningObicanVezbac'
CREATE INDEX [IX_FK_ProbniTreningObicanVezbac]
ON [dbo].[ProbniTrenings]
    ([ObicanVezbacIdObicanVezbac]);
GO

-- Creating foreign key on [OpremaUteretaniIdOprema] in table 'ObicanVezbacs'
ALTER TABLE [dbo].[ObicanVezbacs]
ADD CONSTRAINT [FK_OpremaUteretaniObicanVezbac]
    FOREIGN KEY ([OpremaUteretaniIdOprema])
    REFERENCES [dbo].[OpremaUteretanis]
        ([IdOprema])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OpremaUteretaniObicanVezbac'
CREATE INDEX [IX_FK_OpremaUteretaniObicanVezbac]
ON [dbo].[ObicanVezbacs]
    ([OpremaUteretaniIdOprema]);
GO

-- Creating foreign key on [TeratanaLokacija] in table 'Radis'
ALTER TABLE [dbo].[Radis]
ADD CONSTRAINT [FK_RadiTeratana]
    FOREIGN KEY ([TeratanaLokacija])
    REFERENCES [dbo].[Teratanas]
        ([Lokacija])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ZaposleniIdBedz] in table 'Radis'
ALTER TABLE [dbo].[Radis]
ADD CONSTRAINT [FK_RadiZaposleni]
    FOREIGN KEY ([ZaposleniIdBedz])
    REFERENCES [dbo].[Zaposlenis]
        ([IdBedz])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RadiZaposleni'
CREATE INDEX [IX_FK_RadiZaposleni]
ON [dbo].[Radis]
    ([ZaposleniIdBedz]);
GO

-- Creating foreign key on [TeratanaLokacija] in table 'Cistis'
ALTER TABLE [dbo].[Cistis]
ADD CONSTRAINT [FK_CistiTeratana]
    FOREIGN KEY ([TeratanaLokacija])
    REFERENCES [dbo].[Teratanas]
        ([Lokacija])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CistacicaIdBedz] in table 'Cistis'
ALTER TABLE [dbo].[Cistis]
ADD CONSTRAINT [FK_CistiCistacica]
    FOREIGN KEY ([CistacicaIdBedz])
    REFERENCES [dbo].[Zaposlenis_Cistacica]
        ([IdBedz])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CistiCistacica'
CREATE INDEX [IX_FK_CistiCistacica]
ON [dbo].[Cistis]
    ([CistacicaIdBedz]);
GO

-- Creating foreign key on [TrenerIdBedz] in table 'Drzis'
ALTER TABLE [dbo].[Drzis]
ADD CONSTRAINT [FK_DrziTrener]
    FOREIGN KEY ([TrenerIdBedz])
    REFERENCES [dbo].[Zaposlenis_Trener]
        ([IdBedz])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CasTreningaIdCasTreninga] in table 'Drzis'
ALTER TABLE [dbo].[Drzis]
ADD CONSTRAINT [FK_DrziCasTreninga]
    FOREIGN KEY ([CasTreningaIdCasTreninga])
    REFERENCES [dbo].[CasTreningas]
        ([IdCasTreninga])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DrziCasTreninga'
CREATE INDEX [IX_FK_DrziCasTreninga]
ON [dbo].[Drzis]
    ([CasTreningaIdCasTreninga]);
GO

-- Creating foreign key on [MenadzerIdBedz] in table 'Teratanas'
ALTER TABLE [dbo].[Teratanas]
ADD CONSTRAINT [FK_TeratanaMenadzer]
    FOREIGN KEY ([MenadzerIdBedz])
    REFERENCES [dbo].[Zaposlenis_Menadzer]
        ([IdBedz])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeratanaMenadzer'
CREATE INDEX [IX_FK_TeratanaMenadzer]
ON [dbo].[Teratanas]
    ([MenadzerIdBedz]);
GO

-- Creating foreign key on [OpremaUteretaniIdOprema] in table 'Zaposlenis_Trener'
ALTER TABLE [dbo].[Zaposlenis_Trener]
ADD CONSTRAINT [FK_TrenerOpremaUteretani]
    FOREIGN KEY ([OpremaUteretaniIdOprema])
    REFERENCES [dbo].[OpremaUteretanis]
        ([IdOprema])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrenerOpremaUteretani'
CREATE INDEX [IX_FK_TrenerOpremaUteretani]
ON [dbo].[Zaposlenis_Trener]
    ([OpremaUteretaniIdOprema]);
GO

-- Creating foreign key on [IdBedz] in table 'Zaposlenis_Cistacica'
ALTER TABLE [dbo].[Zaposlenis_Cistacica]
ADD CONSTRAINT [FK_Cistacica_inherits_Zaposleni]
    FOREIGN KEY ([IdBedz])
    REFERENCES [dbo].[Zaposlenis]
        ([IdBedz])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdBedz] in table 'Zaposlenis_Trener'
ALTER TABLE [dbo].[Zaposlenis_Trener]
ADD CONSTRAINT [FK_Trener_inherits_Zaposleni]
    FOREIGN KEY ([IdBedz])
    REFERENCES [dbo].[Zaposlenis]
        ([IdBedz])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdBedz] in table 'Zaposlenis_Menadzer'
ALTER TABLE [dbo].[Zaposlenis_Menadzer]
ADD CONSTRAINT [FK_Menadzer_inherits_Zaposleni]
    FOREIGN KEY ([IdBedz])
    REFERENCES [dbo].[Zaposlenis]
        ([IdBedz])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdBedz] in table 'Zaposlenis_Recepcionista'
ALTER TABLE [dbo].[Zaposlenis_Recepcionista]
ADD CONSTRAINT [FK_Recepcionista_inherits_Zaposleni]
    FOREIGN KEY ([IdBedz])
    REFERENCES [dbo].[Zaposlenis]
        ([IdBedz])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdOprema] in table 'OpremaUteretanis_Sprave'
ALTER TABLE [dbo].[OpremaUteretanis_Sprave]
ADD CONSTRAINT [FK_Sprave_inherits_OpremaUteretani]
    FOREIGN KEY ([IdOprema])
    REFERENCES [dbo].[OpremaUteretanis]
        ([IdOprema])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdOprema] in table 'OpremaUteretanis_Tegovi'
ALTER TABLE [dbo].[OpremaUteretanis_Tegovi]
ADD CONSTRAINT [FK_Tegovi_inherits_OpremaUteretani]
    FOREIGN KEY ([IdOprema])
    REFERENCES [dbo].[OpremaUteretanis]
        ([IdOprema])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------