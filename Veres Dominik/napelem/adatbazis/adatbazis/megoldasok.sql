-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
create database napsutes
default charset=utf8
collate utf8_hungarian_ci


-- 3. feladat:
UPDATE `regiok` 
SET regioNev ="Észak-Írország"
WHERE regioNev = "Észak Írország";

-- 4. feladat:
SELECT COUNT(id) as rekordszam, Avg(perc) as atlag  
FROM `meresek` WHERE 1

-- 5. feladat:
SELECT ev, sum(perc)/60 as orak FROM `meresek` INNER JOIN regiok on meresek.regioId = regiok.id WHERE regioNev ="Anglia" and ev>=1990 and ev<=2000 GROUP by ev ORDER by ev DESC

-- 6. feladat:
SELECT ev, perc, regioNev FROM `meresek`
INNER JOIN regiok
on regiok.id = meresek.regioId
where ho = "2" and perc> 6000
ORDER by perc DESC

