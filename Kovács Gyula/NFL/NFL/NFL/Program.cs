using System;
using System.Collections.Generic;
using System.IO;

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

            Console.WriteLine("5.feladat: A statisztikában {0} irányító szerepel", jatekosok.Count);

            Console.WriteLine("7. feladat: Legjobb irányítók: ");
            foreach (var j in jatekosok)
            {
                if (j.Mutató >= 100 && j.YardMeterben >= 4000)
                {
                    Console.WriteLine("\t {0} ( (írányító mutató: {1}. Passzok {2}m",
                        j.FormazottNev(j.Név), j.Mutató, j.YardMeterben);
                }
            }

            Console.Write("8.feladat: Eladott labdák száma:");
            int eladott = int.Parse(Console.ReadLine());
            List<string> legtobbeladott = new List<string>();
            foreach (var Q in jatekosok)
            {
                if (Q.Eladott > eladott)
                {
                    legtobbeladott.Add(Q.FormazottNev(Q.Név));

                }
            }
            legtobbeladott.Sort();
            File.WriteAllLines("legtobbeteladott.txt", legtobbeladott);


            int legjobb = 0;
            for (int Q = 1; Q < jatekosok.Count; Q++)
            {
                if (jatekosok[Q].TDK > jatekosok[legjobb].TDK)
                {
                    legjobb = Q;
                }
            }

            Console.WriteLine("9.feladat: A legtöbb TD-t szerző játékos:");
            Console.WriteLine("\t Neve:{0} ", jatekosok[legjobb].Név);
            Console.WriteLine("\t TDK száma:{0} ", jatekosok[legjobb].TDK);
            Console.WriteLine("\t Eladott labdák száma:{0} ", jatekosok[legjobb].Eladott);

            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var q in jatekosok)
            {
                if (stat.ContainsKey(q.Egyetem))
                {
                    stat[q.Egyetem]++;
                }
                else
                {
                    stat.Add(q.Egyetem, 1);
                }

            }
            Console.WriteLine("10.feladat: legsikeresebb egyetemek:");
            foreach (var s in stat)
            {
                if (s.Value > 1)
                {
                    Console.WriteLine("\t {0} - {1}", s.Key, s.Value);
                }
            }
        }
    }
}
