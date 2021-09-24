/* Città da cui si può partire per Roma */
SELECT DISTINCT cittaPartenza FROM Volo 
WHERE cittaArrivo = 'Roma' 
ORDER BY cittaPartenza

/* Aereoporti in cui non è noto il numero di piste */
SELECT citta, nazione FROM Aereoporto 
WHERE numPiste IS NULL 
ORDER BY nazione, citta

/* Numero di passeggeri e di merci per un volo */
SELECT v.idVolo, a.tipoAereo, a.numPasseggeri, a.qtaMerci FROM Volo v, Aereo a 
WHERE v.tipoAereo = a.tipoAereo AND a.qtaMerci > 0 AND a.numPasseggeri > 0
ORDER BY 1