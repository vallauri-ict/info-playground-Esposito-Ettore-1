GO

CREATE TRIGGER [dbo].[StioricoUpdate]
    ON [dbo].[Driver]
    FOR UPDATE
    AS
    BEGIN
		SET NoCount ON

		DECLARE @Data date
		SET @Data = CURRENT_TIMESTAMP

		INSERT INTO StoricoAggiornamenti(number, full_name, country, date_birth, team_id, podiums_number, numberNew, full_nameNew, countryNew, date_birthNew, team_idNew, podiums_numberNew, [data])
			SELECT d.*, i.*, @Data FROM inserted i, deleted d WHERE i.number = d.number
    END
GO

CREATE TRIGGER [dbo].[StoricoDelete]
    ON [dbo].[Driver]
    FOR DELETE
    AS
    BEGIN
        SET NoCount ON

		DECLARE @Data date
		SET @Data = CURRENT_TIMESTAMP

		INSERT INTO StoricoCancellazioni (number, full_name, country, date_birth, team_id, podiums_number, [data])
			SELECT d.number, d.full_name, d.country, d.date_birth, d.team_id, d.podiums_number, @Data FROM deleted d
    END