/* 1 */
SELECT f.Titolo FROM Film f
WHERE f.Regista = (SELECT Regista FROM Film f2 WHERE f2.Titolo = 'Casablanca');

/* 2 */
SELECT DISTINCT f.Titolo FROM Attori a, Film f, Recita r
WHERE a.CodAttore = r.CodAttore AND f.CodFilm = r.CodFilm
AND a.Nome IN ('M.Mastroianni', 'S.Loren');

/* 3 */
SELECT DISTINCT f.Titolo, f.Genere FROM Film f, Proiezioni p
WHERE f.CodFilm = p.CodFilm
AND p.DataProiezione = '2004-12-25';

/* 4 */
SELECT f.Titolo, f.Regista FROM Film f
WHERE (SELECT COUNT(*) FROM Attori a, Recita r WHERE a.CodAttore = r.CodAttore AND f.CodFilm = r.CodFilm) < 6;

/* 5 */
SELECT f.Titolo from Film f
WHERE NOT EXISTS(SELECT * FROM Sale s, Proiezioni p WHERE s.CodSala = p.CodSala AND f.CodFilm = p.CodFilm AND s.Citta = 'Pisa');

/* 6 */
SELECT a.Nome FROM Attori a
WHERE NOT EXISTS(SELECT * FROM Film f, Recita r WHERE f.CodFilm = r.CodFilm AND a.CodAttore = r.CodAttore AND f.Regista = 'Fellini')
AND a.Nazionalita = 'IT';