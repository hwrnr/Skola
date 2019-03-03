--izlistati broj radnika i ukupno anganzovanje za svaki projekat

(select radproj.Spr "Sifra projekta", max(projekat.Nap) "Ime projekta", COUNT(distinct radproj.Mbr) "Broj radnika", sum (radproj.Brc) "Angazovanje"
 from radproj, projekat
 where projekat.Spr = radproj.Spr
 GROUP by radproj.Spr)