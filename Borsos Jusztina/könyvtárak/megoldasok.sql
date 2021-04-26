-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 8. feladat:


CREATE DATABASE konyvtarak 
DEFAULT CHARSET=utf8 
COLLATE utf8_hungarian_ci;

-- 10. feladat:
Update megyek
set megyeNev = "Budapest"
where megyeNev = "Bp";


-- 11. feladat:
SELECT konyvtarNEV, irsz FROM `konyvtarak`
WHERE konyvtarNev Like "%Szakkönyvtár%";

-- 12. feladat:
SELECT konyvtarNev, irsz, cim FROM `konyvtarak` 
WHERE irsz Like "1%"
Order by irsz ASC;

-- 13. feladat:
SELECT telepNev, COUNT(id) as konyvtarDarab FROM `konyvtarak`
INNER JOIN telepulesek 
ON telepulesek.irsz = konyvtarak.irsz
GROUP By telepNev
HAVING konyvtarDarab >= 7;

-- 14. feladat:

SELECT megyeNev, Count(irsz) as telepulesDarab FROM `megyek`
INNER JOIN telepulesek 
On telepulesek.megyeId=megyek.id
where irsz Not Like "1%"
GROUP by megyeNev
ORDER BY telepulesDarab DESC;

