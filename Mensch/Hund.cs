using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public class Hund:ITier
    {
        public string name { get; set; }

        public void laut()
        {
            Console.Out.WriteLine("Wuff");
        }
    }
}