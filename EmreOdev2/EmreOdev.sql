CREATE TABLE [dbo].[ders] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [dersadi]  VARCHAR (50) NOT NULL,
    [derskodu] VARCHAR (50) NOT NULL,
    [ogretmen] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[ogrenci] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [oadi]    VARCHAR (50) NOT NULL,
    [osoyadi] VARCHAR (50) NOT NULL,
    [numara]  VARCHAR (50) NOT NULL,
    [posta]   VARCHAR (50) NOT NULL,
    [sifre]   NCHAR (10)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[ogretmen] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [hadi]    VARCHAR (50) NOT NULL,
    [hsoyadi] VARCHAR (50) NOT NULL,
    [unvan]   VARCHAR (50) NOT NULL,
    [posta]   VARCHAR (50) NOT NULL,
    [sifre]   VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


