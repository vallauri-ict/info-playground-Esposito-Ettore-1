/* 1 */
SELECT Targa, Marca FROM Auto
WHERE Cilindrata > 2000 OR Potenza > 120
ORDER BY 1

/* 2 */
SELECT p.Nome, a.Targa FROM Auto a, Proprietario p
WHERE a.CodF = p.CodF
AND (Cilindrata > 2000 OR Potenza > 120)
ORDER BY 1, 2

/* 3 */
SELECT p.Nome, a.Targa FROM Auto a, Proprietario p, Assicurazione ass
WHERE a.CodF = p.CodF AND a.CodAss = ass.CodAss
AND (Cilindrata > 2000 OR Potenza > 120) AND ass.Nome = 'SARA'
ORDER BY 1, 2

/* 4 */
SELECT a.Targa, p.Nome FROM Auto a, Proprietario p, Assicurazione ass, AutoCounvolta ac, Sinistro s
WHERE a.CodF = p.CodF AND a.CodAss = ass.CodAss AND a.Targa = ac.Targa AND ac.CodS = s.CodS
AND ass.Nome = 'SARA' AND s.DataA = '2002-01-20'
ORDER BY 1

/* 5 */
SELECT ass.Nome, ass.Sede, COUNT(1) FROM Assicurazione ass, Auto a
WHERE a.CodAss = ass.CodAss
GROUP BY ass.Nome, ass.Sede
ORDER BY 1, 2, 3

/* 6 */
SELECT a.Targa, COUNT(1) FROM Auto a, AutoCounvolta ac
WHERE a.Targa = ac.Targa
AND a.Marca = 'Fiat'
GROUP BY a.Targa
ORDER BY 1

/* 7 */
SELECT a.Targa, ass.Nome, SUM(ac.CostoDanno) FROM Auto a, Assicurazione ass, AutoCounvolta ac
WHERE a.CodAss = ass.CodAss AND a.Targa = ac.Targa
AND (SELECT COUNT(1) FROM AutoCounvolta ac1 WHERE a.Targa = ac1.Targa) > 1
GROUP BY a.Targa, ass.Nome
ORDER BY 1

/* 8 */
SELECT p.CodF, p.Nome FROM Proprietario p
WHERE (SELECT COUNT(1) FROM Auto a WHERE p.CodF = a .CodF) > 1
ORDER BY 2

/* 9 */
SELECT a.Targa FROM Auto a
WHERE NOT EXISTS (SELECT 1 FROM AutoCounvolta ac, Sinistro s WHERE ac.Targa = a.Targa AND s.CodS = ac.CodS AND s.DataA > '2001-01-20')
ORDER BY 1

/* 10 */
SELECT s.CodS FROM Sinistro s
WHERE EXISTS (SELECT 1 FROM AutoCounvolta ac, Auto a WHERE ac.CodS = s.CodS AND a.Targa = ac.Targa AND a.Cilindrata < 2000)
ORDER BY 1