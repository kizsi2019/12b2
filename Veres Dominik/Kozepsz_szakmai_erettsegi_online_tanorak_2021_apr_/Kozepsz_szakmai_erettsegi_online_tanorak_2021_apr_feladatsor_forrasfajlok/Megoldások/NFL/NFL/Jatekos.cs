using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Jatekos
    {
        public string Nev { get; set;} // class ba kell olvasási és beállítási engedélyt adni
        public int Yardok { get; set; }
        public int Kiserlet { get; set; }
        public int Passzok { get; set; }
        public int TDK { get; set; }
        public int Eladott { get; set; }
        public double Mutató { get; set; }
        public string Egyetem { get; set; }

        #region Feladat 6
        public int YardToM
        { get
            {
                return (int)Math.Round(Yardok * 0.9144);
            }
        }
        #endregion

        public Jatekos(string sor) {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Yardok = int.Parse(adatok[1]);
            Kiserlet = int.Parse(adatok[2]);
            Passzok = int.Parse(adatok[3]);
            TDK = int.Parse(adatok[4]);
            Eladott = int.Parse(adatok[5]);
            Mutató = Konvertal(adatok[6]);
            Egyetem = adatok[7];
        }

        private double Konvertal(string iranyitoMutato)
        {
            var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            iranyitoMutato = iranyitoMutato.Replace(",", decimalSeparator).Replace(".", decimalSeparator);
            if (double.TryParse(iranyitoMutato, out var ertek))
                return ertek;
            throw new FormatException("Hibás érték (irányítómutató)");
        }

        public string FormazottNev(string nev)
        {
            var n = nev.Split(' ');
            n[n.Length - 1] = n[n.Length - 1].ToUpper();
            return string.Join(" ", n);
        }


    }
}
