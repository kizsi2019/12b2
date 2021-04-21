using System;
using System.Collections.Generic;
using System.IO;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        struct sudoku
        {

        }
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader sr = new StreamReader("feladvanyok.txt");
            while (!sr.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine("3. feladat: Beolvasva {0} feladvány", feladvanyok.Count);

            int meret = 0;
            do
            {
                Console.Write("4. feladat: Kérem a feladvány méetét: ");
                meret = Convert.ToInt32(Console.ReadLine());
            } while (4 > meret || meret > 9);

            List<Feladvany> nelemufeladvanyok = new List<Feladvany>();
            foreach (Feladvany i in feladvanyok)
            {
                if (meret == i.Meret)
                {
                    nelemufeladvanyok.Add(i);
                }
                
            }
            Console.WriteLine("{0}x{0} méretű feladványből {1} darab van tárolva",meret,nelemufeladvanyok.Count);

            Random rnd = new Random();
            int index = rnd.Next(nelemufeladvanyok.Count);

            var kivalasztottfeladvany = nelemufeladvanyok[index];

            Console.WriteLine("5. feladat: A kiválasztott feladvány: ");
            Console.WriteLine(kivalasztottfeladvany.Kezdo);

            double db = 0;
            foreach (char i in kivalasztottfeladvany.Kezdo)
            {
                if (i != '0')
                {
                    db++;
                }
            }
            Console.WriteLine("6. feladat: A feladvány kitöltöttsége: {0:f0}%", 100 * db / kivalasztottfeladvany.Kezdo.Length);

            Console.WriteLine("7. feladat: A feladvány kirajzolva:");
            kivalasztottfeladvany.Kirajzol();

            string fajlNev = string.Format("sudoku{0}.txt",meret);
            StreamWriter sw = new StreamWriter(fajlNev);

            foreach (var i in nelemufeladvanyok)
            {
                sw.WriteLine(i.Kezdo);
            }
            sw.Close();
            Console.WriteLine("8. feladat: {0} állomány {1} feladvánnyal létrehozva",fajlNev, nelemufeladvanyok.Count);
            Console.ReadKey();
        }
    }
}
