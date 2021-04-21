using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> jatekosok = new List<Jatekos>();

            foreach (var sor in File.ReadAllLines("NFL_iranyitok.txt"))
            {
                jatekosok.Add(new Jatekos(sor));
            }

            #region feladat 5
            Console.WriteLine("5. Feladat: A statsisztikában {0} irányító szerepel", jatekosok.Count());
            #endregion

            #region feladat 7
            Console.WriteLine("7. feladat:");
            foreach (Jatekos i in jatekosok)
            {
                if (i.Mutató>=100 && (i.YardToM) >= 4000)
                {
                    Console.WriteLine("\t{0} (Irányító mutató:{1}. Passzok:{2}m.)",i.FormazottNev(i.Nev), i.Mutató,i.YardToM);
                }
            }
            #endregion

            #region Feladat 8
            Console.Write("8. Feladat: Adjon meg az eladatt labdák számát:");
            int eladott = int.Parse(Console.ReadLine());
            List<string> legtobbeladatt = new List<string>();

            foreach (Jatekos i in jatekosok)
            {
                if (i.Eladott >eladott)
                {
                    legtobbeladatt.Add(i.FormazottNev(i.Nev));
                }
            }
            legtobbeladatt.Sort();

            File.WriteAllLines("legtöbbetteladott.txt", legtobbeladatt);

            #endregion
            #region 9. Feladat
            Console.WriteLine("9. Feladat: A legtöbb TD-t szerző játékos:");

            int legjobb = 0;
            for (int i = 1; i < jatekosok.Count; i++)
            {
                if (jatekosok[i].TDK > jatekosok[legjobb].TDK )
                {
                    legjobb = i;
                }
            }

            Console.WriteLine("\t Neve: {0}", jatekosok[legjobb].Nev);
            Console.WriteLine("\t TD-k száma: {0}", jatekosok[legjobb].TDK);
            Console.WriteLine("\t Eladott labdák: {0}", jatekosok[legjobb].Eladott);

            #endregion
            #region 9. Feladat
            Dictionary<string, int> stat = new Dictionary<string, int>();

            foreach (var i in jatekosok)
            {
                if (stat.ContainsKey(i.Egyetem))
                {
                    stat[i.Egyetem]++;
                }
                else
                {
                    stat.Add(i.Egyetem, 1);
                }
            }
            Console.WriteLine("10. feladat: Legsikeresebb egyetemek");
            
            foreach (var i in stat)
            {
                if (i.Value > 1)  Console.WriteLine("\t {0} - {1}", i.Key, i.Value);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
