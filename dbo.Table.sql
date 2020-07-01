CREATE TABLE [dbo].[Contato]
(
	[Codigo] INT NOT NULL PRIMARY KEY, 
    [ DadosContato] VARBINARY(MAX) NULL, 
    [Tipo] VARBINARY(MAX) NULL, 
    [Cliente] NCHAR(10) NULL
)
