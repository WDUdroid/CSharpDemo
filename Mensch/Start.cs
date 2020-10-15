using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    class Start
    {
        static void Main()
        {
            // Display the number of command line arguments.
            Console.WriteLine("Tiere werden erstellt...");
            var schlange1 = new Schlange();
            var hund1 = new Hund();
            var katze1 = new Katze();

            Console.WriteLine("Tiere werden gefangen...");

            var dangerNoodle = new Haustier(schlange1);
            var kitty = new Haustier(katze1);
            var chonker = new Haustier(hund1);
            var mystery = new Haustier();

            var list = new List<Haustier>();

            list.Add(dangerNoodle);
            list.Add(kitty);
            list.Add(chonker);
            list.Add(mystery);

            Console.WriteLine("Gott erschuf die Tiere...");
            Console.WriteLine("Menschen werden erstellt...");

            var mensch = new Mensch(list);

            Console.WriteLine("Tiere riefen Gott an");

            foreach (Haustier tier in list)
            {
                tier.spezies.laut();
            }
        }
    }
}