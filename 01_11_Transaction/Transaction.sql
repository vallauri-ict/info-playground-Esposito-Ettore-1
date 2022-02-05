BEGIN TRANSACTION;

	INSERT INTO Anagrafica(Nome, Stipendio) VALUES ('Neri', 35000);
	SAVE TRANSACTION SavePoint1;

	INSERT INTO Anagrafica(Nome, Stipendio) VALUES ('Viola', 35000);
	SAVE TRANSACTION SavePoint2;

	INSERT INTO Anagrafica(Nome, Stipendio) VALUES ('Marrone', 25000);

	SELECT * FROM Anagrafica; /* Con Marrone */

	ROLLBACK TRANSACTION SavePoint2;

	SELECT * FROM Anagrafica; /* Senza Marrone */

COMMIT;