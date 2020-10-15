using System;
using System.Collections.Generic;
using System.Text;

namespace Mensch
{
    public class Schlange:ITier
    {
        public string name { get; set; }

        public void laut()
        {
            Console.Out.WriteLine("Hisssss");
        }
    }
}