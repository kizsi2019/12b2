-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
Create Database formula1
DEFAULT CHARSET=utf8 
COLLATE utf8_hungarian_ci;

-- 3. feladat:
UPDATE nagydijak set korokszama = "70" WHERE nev like "Hungarian Grand Prix"

-- 4. feladat:
SELECT vezeteknev,rajtszam, csapatnev, 2019- Left(szuletesidatum,4)  as eletkor FROM `pilotak` WHERE 1
order by eletkor DESC

-- 5. feladat:
SELECT nev,vezeteknev, keresztnev, versenynap FROM `nagydijak`
inner join eredmenyek
on nagydijak.id = eredmenyek.nagydijid
INNER join pilotak
on eredmenyek.pilotaid = pilotak.id
WHERE helyezes = '1' 
ORDER by versenynap asc;

-- 6. feladat:
SELECT concat(keresztnev,' ', vezeteknev) as nev, csapatnev, SUM(pontszam) as osszpontszam
FROM `pilotak`
inner join eredmenyek
on eredmenyek.pilotaid = pilotak.id
GROUP by pilotaid  
ORDER BY osszpontszam DESC
Limit 3
