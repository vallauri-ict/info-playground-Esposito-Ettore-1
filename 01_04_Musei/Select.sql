/* 8 */
SELECT m.NomeM, COUNT(1) AS NOpere FROM Museo m, Opera o, Artista a 
WHERE m.NomeM = o.NomeM AND o.NomeA = a.NomeA
AND m.Citta = 'Londra' AND a.Nazionalita = 'IT'
GROUP BY m.NomeM
ORDER BY 1

/* 9 */
SELECT m.nomeM FROM Museo m
WHERE m.Citta = 'Londra' 
AND NOT EXISTS (SELECT 1 FROM Opera o WHERE o.NomeM = m.NomeM AND o.NomeA = 'Tiziano')
ORDER BY 1

/* 10 */
SELECT m.nomeM FROM Museo m
WHERE m.Citta = 'Londra' 
AND NOT EXISTS (SELECT 1 FROM Opera o WHERE o.NomeM = m.NomeM AND o.NomeA <> 'Tiziano')
ORDER BY 1

SELECT m.nomeM FROM Museo m
WHERE m.Citta = 'Londra' 
AND m.NomeM NOT IN (SELECT m1.NomeM FROM Museo m1, Opera o WHERE o.NomeM = m1.NomeM AND o.NomeA <> 'Tiziano')
ORDER BY 1

SELECT m.nomeM FROM Museo m
WHERE m.Citta = 'Londra' 
AND 'Tiziano' = ALL (SELECT o.NomeA FROM Opera o WHERE o.NomeM = m.NomeM)
ORDER BY 1

/* 11 */
SELECT a.NomeA, COUNT(1) AS NOpere FROM Museo m, Opera o, Artista a
WHERE m.NomeM = o.NomeM AND o.NomeA = a.NomeA
AND M.NomeM = 'Galleria degli Uffizi'
GROUP BY a.NomeA
ORDER BY 1

/* 12 */
SELECT m.NomeM FROM Museo m
WHERE (SELECT COUNT(1) FROM Opera o, Artista a WHERE o.NomeM = m.nomeM AND a.NomeA = o.NomeA AND a.Nazionalita = 'IT') >= 2
ORDER BY 1

SELECT o.NomeM FROM Opera o, Artista a 
WHERE o.NomeA = a.NomeA AND  a.Nazionalita = 'IT'
GROUP BY O.NomeM
HAVING COUNT(1) >= 2 /* Questa è la WHERE per la GROUP BY */

/* 13 */
SELECT o.Titolo, a.NomeA FROM Opera o, Artista a
WHERE a.NomeA = o.NomeA AND a.Nazionalita = 'IT'
AND NOT EXISTS (SELECT 1 FROM Personaggio p WHERE p.Codice = o.Codice)
ORDER BY 1

/* 14 */
SELECT m.NomeM FROM Museo m
WHERE m.Citta = 'Londra'
AND NOT EXISTS (SELECT 1 FROM Artista a, Opera o WHERE a.NomeA = o.NomeA AND o.NomeM = m.NomeM AND a.Nazionalita = 'IT' AND a.NomeA <> 'Tiziano')
ORDER BY 1

/* 15 */
SELECT m.NomeM, a.Nazionalita, COUNT(1) FROM Museo m, Opera o, Artista a
WHERE m.NomeM = o.NomeM AND o.NomeA = a.NomeA
GROUP BY m.NomeM, a.Nazionalita
order by 1, 2