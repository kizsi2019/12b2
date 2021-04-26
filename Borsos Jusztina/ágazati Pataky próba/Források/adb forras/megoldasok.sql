-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 8. feladat:
CREATE DATABASE kobanyavasut
DEFAULT CHARSET=utf8 
COLLATE utf8_hungarian_ci;

-- 10. feladat:
INSERT Into allomasok (id, allomasNev)
VALUES (16 , "Dabas")


-- 11. feladat:
UPDATE vonatok 
Set jaratTipus="sz" 
where jaratSzam = "541"

-- 12. feladat:
SELECT Count(jaratSzam) as járatok_száma FROM `vonatok`
WHERE allomas = "Felső" AND jaratTipus = "zó";


-- 13. feladat:

SELECT MIN(indulas) as elso, Max(indulas) as utolso FROM `vonatok` 
INNER JOIN allomasok 
on allomasok.id = vonatok.vegAll 
WHERE allomasNev = "Monor" AND allomas ="Alsó"

-- 14. feladat:
SELECT indulas,allomas, erkezIdo FROM `vonatok`
INNER JOIN allomasok
on allomasok.id = vonatok.vegAll
WHERE allomasNev = "Szolnok"
ORDER by indulas asc 
LIMIT 5;

