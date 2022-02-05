CREATE PROCEDURE [dbo].[Bonifico]
	@importo int = 0,
	@contoSorgente int,
	@contoDestinatario int
AS
	if(@contoSorgente = @contoDestinatario)
		return -2
	BEGIN TRANSACTION

		INSERT INTO Movimenti(Importo, [Data], Tipo, CodConto)
			VALUES (@importo, CURRENT_TIMESTAMP, 'P', @contoSorgente)
		if(@@ERROR <> 0)
			BEGIN
				ROLLBACK;
				/* 16 = severity level tra 1 e 18, 1 = state tra 1 e 255 */
				RAISERROR('Errore durante il prelievo', 16, 1)
				return -1
			END

		INSERT INTO Movimenti(Importo, [Data], Tipo, CodConto)
			VALUES (@importo, CURRENT_TIMESTAMP, 'V', @contoDestinatario)
		if(@@ERROR <> 0)
			BEGIN
				ROLLBACK;
				RAISERROR('Errore durante il versamento', 16, 1)
				return -1
			END

	COMMIT
RETURN 0
