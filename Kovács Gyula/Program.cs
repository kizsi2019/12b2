using System;
using System.Collections.Generic;
using System.Linq;

namespace PeldaLinqWhere
{
    struct Pelda
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var elemek = new List<Pelda>
            {
                new Pelda { X = 10, Y = 20 },
                new Pelda { X = 11, Y = 23 },
                new Pelda { X = 44, Y = 42 },
                new Pelda { X = 7, Y = 1 },
                new Pelda { X = 9, Y = 12 },
            };

            {
                var Max = elemek.Max(i => i.X);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}