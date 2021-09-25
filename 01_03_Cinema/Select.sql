SELECT Nome FROM Sala 
WHERE Citta = 'Pisa'

SELECT Titolo FROM Film 
WHERE Regista = 'F. Fellini' AND AnnoProduzione > 1960
ORDER BY AnnoProduzione DESC

SELECT Titolo, Durata FROM Film 
WHERE (Genere = 'Fantascienza' AND Nazionalita = 'JP') OR (Nazionalita = 'FR' AND AnnoProduzione > 1990)
ORDER BY Nazionalita, AnnoProduzione DESC

SELECT Titolo FROM Film
WHERE (Nazionalita = 'JP' AND Genere = 'Fantascienza' AND AnnoProduzione > 1990) OR Nazionalita = 'FR'
ORDER BY Nazionalita, AnnoProduzione DESC

SELECT f1.Titolo, f1.Regista FROM Film f1
WHERE f1.Regista IN (SELECT DISTINCT f2.Regista FROM Film f2 WHERE f2.Titolo = 'Casablanca')
ORDER BY 2, 1

SELECT DISTINCT f.Titolo, f.Genere FROM Proiezione p, Film f
WHERE f.CodFilm = p.CodFilm AND p.DataProiezione = '2004-12.25'
ORDER BY 1

SELECT DISTINCT f.Titolo, f.Genere FROM Proiezione p, Film f, Sala s
WHERE f.CodFilm = p.CodFilm AND p.DataProiezione = '2004-12.25' AND s.CodSala = p.CodSala AND s.Citta = 'Napoli'
ORDER BY 1

SELECT DISTINCT s.Nome FROM Sala s, Proiezione p, Attore a, Recita r
WHERE (s.CodSala = p.CodSala AND p.CodFilm = r.CodFilm AND r.CodAttore = a.CodAttore)
AND (p.DataProiezione = '2004-12-25' AND a.Nome = 'R. Williams' AND s.Citta = 'Napoli')
ORDER BY 1

SELECT DISTINCT f.Titolo FROM Film f, Attore a, Recita r
WHERE (r.CodAttore = a.CodAttore AND r.CodFilm = f.CodFilm)
AND a.Nome IN ('Tizio', 'Caio')
ORDER BY 1

/*10*/
SELECT f.titolo FROM Film f, Attore a1, Recita r1, Attore a2, Recita r2
WHERE (f.CodFilm = r1.CodFilm AND f.CodFilm = r2.CodFilm AND r1.CodAttore = a1.CodAttore AND r2.CodAttore = a2.CodAttore)
AND a1.Nome = 'Tizio' AND A2.Nome = 'Caio'
ORDER BY 1

/*10*/
SELECT f.titolo FROM Film f, Attore a, Recita r 
WHERE (f.CodFilm = r.CodFilm AND r.CodAttore = a.CodAttore AND a.Nome = 'Tizio') 
AND f.CodFilm IN (SELECT f2.CodFilm FROM Film f2, Attore a2, Recita r2 
	WHERE f2.CodFilm = r2.CodFilm AND r2.CodAttore = a2.CodAttore AND a2.Nome = 'Caio')
ORDER BY 1

SELECT f.Titolo, a.Nome FROM Film f, Attore a, Recita r
WHERE f.CodFilm = r.CodFilm AND r.CodAttore = a.CodAttore
AND a.Nazionalita = 'FR'
ORDER BY 1, 2

SELECT f.Titolo, s.Sala FROM Film f, Sala s, Proiezione p
WHERE f.CodFilm = p.CodFilm AND p.CodSala = s.CodSala
AND p.DataProiezione BETWEEN '2005-01-01' AND '2005-01-31' and s.Citta = 'Pisa'
ORDER BY 2, 1