CREATE TABLE Impiegato 
(
	nome VARCHAR(30) PRIMARY KEY,
	titolo VARCHAR(50),
	eta INT NOT NULL,
	salario DECIMAL(12, 2) NOT NULL,
	dip CHAR(1) NOT NULL
)

CREATE TABLE [dbo].[Cliente]
(
	[IdCliente] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(30) NOT NULL, 
    [cognome] VARCHAR(30) NOT NULL, 
    [citta] VARCHAR(50) NOT NULL, 
    [stato] VARCHAR(3) NOT NULL
)

CREATE TABLE [dbo].[Acquisto]
(
	[IdAcquisto] INT NOT NULL PRIMARY KEY IDENTITY, 
    [idCliente] INT NOT NULL, 
    [dataOrdinazione] DATE NOT NULL, 
    [item] INT NOT NULL, 
    [quantita] INT NOT NULL, 
    [prezzo] DECIMAL(12,2) NOT NULL
)
