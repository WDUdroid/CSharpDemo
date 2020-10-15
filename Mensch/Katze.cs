using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public class Katze : ITier
    {
        public string name { get; set; }

        public void laut()
        {
            Console.Out.WriteLine("Miau");
        }
    }
}