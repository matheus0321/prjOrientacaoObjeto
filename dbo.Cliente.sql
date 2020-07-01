CREATE TABLE [dbo].[Cliente] (
    [Codigo]       INT           NOT NULL,
    [Nome]         VARCHAR (50) NULL,
    [Tipo]         INT           NULL,
    [DataCadastro] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Codigo] ASC)
);

